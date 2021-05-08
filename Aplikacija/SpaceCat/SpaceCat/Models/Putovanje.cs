using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceCat
{
    public class Putovanje
    {
        public int ID { get; }
        public List<Macka> SpisakMacaka { get; set; }
        public DateTime VrijemePolaska { get; set; }
        public Destinacija Destinacija { get; set; }
        public DateTime KrajPutovanja { get; set; }
        public Putovanje(DateTime vrijemePolaska, Destinacija destinacija, DateTime krajPutovanja)
        {
            VrijemePolaska = vrijemePolaska;
            Destinacija = destinacija;
            KrajPutovanja = krajPutovanja;
        }
        public void DodajMacku(Macka macka)
        {
            SpisakMacaka.Add(macka);
        }
    }
}
