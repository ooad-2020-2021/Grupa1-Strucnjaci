using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceCat
{
    public class Macka: IProfil
    {
        #region Properties
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string KorisnickoIme { get; set; }
        [Required]
        [Range(5, int.MaxValue, ErrorMessage = "Lozinka mora imati najmanje 5 znakova")]
        public string Lozinka { get; set; }
        [Required]
        public string ImeVlasnika { get; set; }
        [Required]
        public string ImeMacke { get; set; }
        [Required]
        public string Drzava { get; set; }
        [Required]
        public PolMacke Pol { get; set; }
        [Required]
        public uint DobMacke { get; set; }
        [Required]
        public bool ZdravaMacka { get; set; }
        [Required]
        public string Slika { get; set; }
        [Required]
        public Paket Paket { get; set; }
        [Required]
        public bool Odabrana { get; set; }
        [Required]
        public bool OdabranaRanije { get; set; }
        [Required]
        public double VjerovatnocaOdabira { get; set; }

        public bool Kompetentna { get; set; }

        public Destinacija Destinacija { get; set; }
        #endregion
        #region Konstruktori
        public Macka() { }
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
        #endregion
    }
}