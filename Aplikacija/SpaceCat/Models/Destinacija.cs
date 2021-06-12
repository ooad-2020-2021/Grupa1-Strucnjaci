using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceCat
{
    public class Destinacija
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public Paket Paket { get; set; }
        [Required]
        public string Naziv { get; set; }
        [Required]
        public string Slika { get; set; }
        #endregion

        #region Konstruktori
        public Destinacija() { }
        public Destinacija(Paket paket, string naziv, string slika)
        {
            Paket = paket;
            Naziv = naziv;
            Slika = slika;
        }
        #endregion
    }

}
