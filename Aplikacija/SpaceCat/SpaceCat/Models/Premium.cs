using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceCat
{
    public class Premium : Macka
    {
        public string BankovniRacun { get; set; }
        public Premium(string korisnickoIme, string lozinka, string imeVlasnika, string imeMacke, string drzava, PolMacke pol, uint dobMacke, bool zdravaMacka, string slika, Paket paket, double vjerovatnocaOdabira, Destinacija dest, string bankovniRacun) : base(korisnickoIme, lozinka, imeVlasnika, imeMacke, drzava, pol, dobMacke, zdravaMacka, slika, paket, vjerovatnocaOdabira, dest)
        {
            BankovniRacun = bankovniRacun;
        }
    }
}
