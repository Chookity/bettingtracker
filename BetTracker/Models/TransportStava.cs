using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetTracker.Models
{
    public class TransportStava
    {
        public string Ime_doma { get; set; }
        public string Ime_goste { get; set; }
        public double Kvota { get; set; }
        public double Kolicina { get; set; }
        public int Izid { get; set; }
        public string Naziv { get; set; }
        public string Izbral { get; set; }
    }
}
