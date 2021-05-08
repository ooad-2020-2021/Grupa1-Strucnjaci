using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceCat
{
    public class Putovanje
    {
        public int id { get; }
        public List<Macka> SpisakMacaka { get; set; }
        public DateTime VrijemePolaska { get; set; }
        public Destinacija Destinacija { get; set; }
        public DateTime KrajPutovanja { get; set; }
        public Putovanje(DateTime vrijemePolaska, Destinacija destinacija, DateTime krajPuta)
        {
            VrijemePolaska = vrijemePolaska;
            Destinacija = destinacija;
            KrajPuta = krajPuta;
        }
        public void DodajMacku(Macka macka)
        {
            SpisakMacaka.Add(Macka);
        }
    }
}
