using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceCat
{
    interface IProfil
    {
        public int ID { get; }
        public string KorisnickoIme { get; }
        public string Lozinka { get; }
    }
}
