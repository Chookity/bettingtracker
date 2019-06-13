using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using BetTracker.DAL;
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;

namespace BetTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;

        public HomeController(IConfiguration config)
        {
            this.configuration = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Vstavi(string ime, string priimek, string email, string drzava, string geslo, string geslo_ponovi)
        {
            // validacija če so vse vnesene in ce sta gesli enaki, TODO pokaze kje je error

            DALDrzava dz = new DALDrzava(configuration);
            List<Drzava> d = dz.vrniVseDrzave();

            ViewBag.Drzava = d;

            if (ime == null)
            {
                ViewBag.Error = "Ime ne sme biti prazno.";
                return View("Registracija");
            }

            if (priimek == null)
            {
                ViewBag.Error = "Priimek ne sme biti prazen.";
                return View("Registracija");
            }

            if (email == null)
            {
                ViewBag.Error = "Email ne sme biti prazen.";
                return View("Registracija");
            }

            if (drzava == null)
            {
                ViewBag.Error = "Država ne sme biti prazna.";
                return View("Registracija");
            }
                

            if ((geslo == null || geslo_ponovi == null) || (geslo != geslo_ponovi))
            {
                ViewBag.Error = "Gesli se ne ujemata";
                return View("Registracija");
            }
            var regex = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$";
            var match = Regex.Match(geslo, regex, RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                ViewBag.Error = "Geslo mora vsebovati minimalno 8 znakov in 1 številka";
                return View("Registracija");
            }
            DALUporabnik dp = new DALUporabnik(configuration);

            int id_uporabnika = dp.addUporabnik(ime, priimek, email, drzava, geslo);

            if (id_uporabnika == -1)
            {
                ViewBag.Error = "Uporabnik s tem email naslovom že obstaja";
                return View("Registracija");
            }

            ViewBag.Success = "Registracija uspešna";
            return View("Login");
        }

        public IActionResult Registracija()
        {
            DALDrzava dz = new DALDrzava(configuration);
            List<Drzava> d = dz.vrniVseDrzave();

            ViewBag.Drzava = d;

            return View();
        }

        public IActionResult Info()
        {
            return View();
        }

        public IActionResult Pogoji()
        {
            return View();
        }

        public IActionResult Login(string email, string geslo)
        {
            // TODO napake
            if (email == null)
            {
                ViewBag.Error = "Email je prazen.";
                return View("Login");
            }

            if (geslo == null)
            {
                ViewBag.Error = "Geslo ne sme biti prazno.";
                return View("Login");
            }
                

            DALUporabnik dp = new DALUporabnik(configuration);

            int login_uspesnost = dp.preveriLogin(email, geslo);

            if (login_uspesnost == 0)
            {
                ViewBag.Error = "Napačno uporabniško ime ali geslo";
                return View("Login");
            }

            TempData["ID_uporabnika"] = login_uspesnost;

            return RedirectToAction("Index", "Dashboard");
        }
    }
}