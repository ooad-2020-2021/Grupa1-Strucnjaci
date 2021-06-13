using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceCat
{
    public class UtisakMacka 
    {
        #region Properties
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string ImeMacke { get; set; }
        [Required]
        public string Slika { get; set; }
        [Required]
        public bool OdabranaRanije { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public Ocjena Ocjena { get; set; }
        #endregion

    }
}