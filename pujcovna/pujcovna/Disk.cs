using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pujcovna
{
    public abstract class Disk
    {
        public string Nazev { get; set; }
        public string Zanr { get; set; }
        public int Cena {  get; set; }
        public Disk(string nazev, string zanr, int cena) 
        {
            Nazev = nazev;
            Zanr = zanr;
            Cena = cena;
        }
    }
}
