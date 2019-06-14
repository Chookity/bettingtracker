using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BetTracker.Models;
using BetTracker.DAL;
using Microsoft.Extensions.Configuration;
using System.Text.RegularExpressions;

namespace BetTracker.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IConfiguration configuration;

        public DashboardController(IConfiguration config)
        {
            this.configuration = config;
        }

        public IActionResult Index()
        {
            if (TempData["ID_uporabnika"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            TempData.Keep();

            return RedirectToAction("Pregled", "Dashboard");
        }

        public IActionResult Profil()
        {
            if (TempData["ID_uporabnika"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            int ID_uporabnika = Convert.ToInt32(TempData["ID_uporabnika"]);

            TempData.Keep();

            DALUporabnik dp = new DALUporabnik(configuration);

            Uporabnik u = dp.dobiPodatke(ID_uporabnika);

            DALDrzava dz = new DALDrzava(configuration);
            List<Drzava> d = dz.vrniVseDrzave();

            ViewBag.Drzava = d;
            ViewBag.Message = u;

            return View();
        }

        public IActionResult PosodobiProfil(Uporabnik u, string geslo_ponovi)
        {

            if (TempData["ID_uporabnika"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            DALUporabnik dpp = new DALUporabnik(configuration);
            int ID_uporabnikaa = Convert.ToInt32(TempData["ID_uporabnika"]);
            Uporabnik uu = dpp.dobiPodatke(ID_uporabnikaa);

            DALDrzava dz = new DALDrzava(configuration);
            List<Drzava> d = dz.vrniVseDrzave();

            ViewBag.Drzava = d;
            ViewBag.Message = uu;
            if (u.Geslo != null || geslo_ponovi != null)
            {
                if (u.Geslo != geslo_ponovi)
                {
                    ViewBag.Error = "Gesli se ne ujemata";
                    return View("Profil");
                }
                var regex = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$";
                var match = Regex.Match(u.Geslo, regex, RegexOptions.IgnoreCase);

                if (!match.Success)
                {
                    ViewBag.Error = "Geslo mora vsebovati minimalno 8 znakov in 1 številka";
                    return View("Profil");
                }
            }

            int ID_uporabnika = Convert.ToInt32(TempData["ID_uporabnika"]);

            TempData.Keep();

            DALUporabnik dp = new DALUporabnik(configuration);

            // todo error če je failov request
            int ratal = Convert.ToInt32(dp.posodobiUporabnika(ID_uporabnika, u));
            ViewBag.Success = "Podatki uspešno posodobljeni";
            return View("Profil");

        }

        public IActionResult Dodaj()
        {
            return View("Dodaj");
        }

        public IActionResult VnesiStavo(string domaca_ekipa, string gostujoca_ekipa, string kvota, string izbera, string stava, string sport, string status)
        {
            if (TempData["ID_uporabnika"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            TempData.Keep();

            if (domaca_ekipa == gostujoca_ekipa)
            {
                ViewBag.Message = "Ekipi ne smeta biti isti.";
                return View("Dodaj");
            }

            if (!(double.TryParse(kvota, out double n)))
            {
                ViewBag.Message = "Kvota mora biti zapisana z , in brez črk.";
                return View("Dodaj");
            }

            if (!(double.TryParse(stava, out double n1)))
            {
                ViewBag.Message = "Količina mora biti zapisana z . in brez črk.";
                return View("Dodaj");
            }

            if (izbera != domaca_ekipa && izbera != gostujoca_ekipa)
            {
                ViewBag.Message = "Izbira se mora ujemati z eno izmed zgoraj napisanih ekip";
                return View("Dodaj");
            }

            DALStava s = new DALStava(configuration);
            s.dodajStavo(Convert.ToInt16(TempData["ID_uporabnika"]), domaca_ekipa, gostujoca_ekipa, kvota, izbera, stava, sport, status);

            TempData.Keep();
            TempData["dodano"] = "Tekma je bila uspešno dodana!";
            return RedirectToAction("Pregled", "Dashboard");
        }

        public IActionResult Pregled()
        {
            if (TempData["ID_uporabnika"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            if (TempData["dodano"] != null)
            {
                ViewBag.dodano = TempData["dodano"];
                TempData["dodano"] = null;
            }
            TempData.Keep();

            List<TransportStava> seznam = new List<TransportStava>();

            DALStava s = new DALStava(configuration);
            seznam = s.dobiVseStave(Convert.ToInt16(TempData["ID_uporabnika"]));

            ViewBag.podatki = seznam;
            ViewBag.win_loss = s.trenutnoStanje(Convert.ToInt16(TempData["ID_uporabnika"]));

            return View();
        }

        public IActionResult Statistika()
        {
            if (TempData["ID_uporabnika"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            TempData.Keep();
            DALStava s = new DALStava(configuration);
            double stanje = s.trenutnoStanje(Convert.ToInt16(TempData["ID_uporabnika"]));
            double maxdobljeno = s.maxDobljena(Convert.ToInt16(TempData["ID_uporabnika"]));
            double maxizguba = s.maxIzguba(Convert.ToInt16(TempData["ID_uporabnika"]));
            string winp = s.winpercantage(Convert.ToInt16(TempData["ID_uporabnika"]));

            List<TransportStava> seznam = new List<TransportStava>();
            seznam = s.dobiVseStave(Convert.ToInt16(TempData["ID_uporabnika"]));

            string cas = "0, ";

            double dozdej = 0;
            foreach (var x in seznam)
            {
                double preracunano = Math.Round(x.Kvota * x.Kolicina, 2);
                if (x.Izid == 1)
                {
                    dozdej = dozdej + Math.Round(x.Kvota * x.Kolicina, 2);
                    cas = cas + dozdej + ", ";
                }
                else if (x.Izid == 2)
                {
                    preracunano = x.Kolicina * -1;
                    dozdej = dozdej + preracunano;
                    cas = cas + dozdej + ", ";
                }
            }
            //ViewBag.skozi_cas = "10, 30, 70, 150, 80, 40, 4, 0, 10, 0";
            ViewBag.skozi_cas = cas;

            ViewBag.stanje = stanje;
            ViewBag.maxdobljeno = maxdobljeno;
            ViewBag.maxizguba = maxizguba;
            ViewBag.winp = winp;
            return View();
        }

        public IActionResult Logout()
        {
            TempData.Remove("ID_uporabnika");

            return View("Odjava");
        }
    }
}
