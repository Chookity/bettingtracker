using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetTracker.Models
{
    public class Uporabnik
    {
        public int ID_Uporabnik { get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public string Email { get; set; }
        public string Drzava { get; set; }
        public string Geslo { get; set; }
    }
}
