using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceCat
{
    public enum Paket
    {
        [Display(Name = "Free")]
        FREE,
        [Display(Name = "Premium")]
        PREMIUM
    }
}
