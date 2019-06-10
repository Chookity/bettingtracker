using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using BetTracker.DAL;
using Microsoft.AspNetCore.Http;

namespace BetTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;

        public HomeController(IConfiguration config) {
            this.configuration = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Vstavi(string ime, string priimek, string email, string drzava, string geslo, string geslo_ponovi)
        {
            // validacija če so vse vnesene in ce sta gesli enaki, TODO pokaze kje je error
            if (ime == null)
                return View("Index");

            if (priimek == null)
                return View("Index");
           
            // neki testiram
            TempData["test"] = "jure";

            if (drzava == null)
                return View("Index");

            if ((geslo == null || geslo_ponovi == null) || (geslo != geslo_ponovi))
                return View("Index");

            DALUporabnik dp = new DALUporabnik(configuration);
            int id_uporabnika = dp.addUporabnik(ime, priimek, email, drzava, geslo);

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
                return View("Login");

            if (geslo == null)
                return View("Login");

            DALUporabnik dp = new DALUporabnik(configuration);

            int login_uspesnost = dp.preveriLogin(email, geslo);

            if (login_uspesnost == 0) {
                return View("Login");
            }

            TempData["ID_uporabnika"] = login_uspesnost;

            return RedirectToAction("Index", "Dashboard");
        }
    }
}