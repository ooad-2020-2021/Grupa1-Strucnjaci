using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceCat
{
    public class Macka:IProfil
    {
        public int ID { get; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string ImeVlasnika { get; set; }
        public string ImeMacke { get; set; }
        public string Drzava { get; set; }
        public PolMacke Pol { get; set; }
        public uint DobMacke { get; set; }
        public bool ZdravaMacka { get; set; }
        public string Slika { get; set; }
        public Paket Paket { get; set; }
        public bool Odabrana { get; set; }
        public bool OdabranaRanije { get; set; }
        public double VjerovatnocaOdabira { get; set; }
        public bool Kompetentna { get; set; }
        public Destinacija Destinacija { get; set; }
        public Macka(string korisnickoIme, string lozinka, string imeVlasnika, string imeMacke, string drzava, PolMacke pol, uint dobMacke, bool zdravaMacka, string slika, Paket paket, double vjerovatnocaOdabira, Destinacija dest)
        {
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            ImeVlasnika = imeVlasnika;
            ImeMacke = imeMacke;
            Drzava = drzava;
            Pol = pol;
            ZdravaMacka = zdravaMacka;
            DobMacke = dobMacke;
            Slika = slika;
            Paket = paket;
            VjerovatnocaOdabira = vjerovatnocaOdabira;
            Destinacija = dest;
            Odabrana = false;
            OdabranaRanije = false;
        }
    }
}