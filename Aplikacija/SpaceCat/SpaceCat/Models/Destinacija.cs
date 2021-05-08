using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceCat
{
    public class Destinacija
    {
        public int ID { get; }
        public Paket Paket { get; set; }
        public string Naziv { get; set; }
        public string Slika { get; set; }
        public Destinacija(Paket paket, string naziv, string slika)
        {
            Paket = paket;
            Naziv = naziv;
            Slika = slika;
        }
    }
   
}
