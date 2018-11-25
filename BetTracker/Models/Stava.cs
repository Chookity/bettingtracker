using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetTracker.Models
{
    public class Stava
    {
        public int ID_stava { get; set; }
        public int ID_ekipa_doma { get; set; }
        public int ID_ekipa_goste { get; set; }
        public int ID_sport { get; set; }
        public double Kvota { get; set; }
        public int Izbera { get; set; }
        public int Izid { get; set; }
        public double Kolicina { get; set; }
        public int ID_uporabnik { get; set; }
    }
}
