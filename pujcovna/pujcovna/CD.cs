using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pujcovna
{
    public class CD : Disk
    {
        public CD(string nazev, string zanr, int cena, string interpret) : base(nazev, zanr, cena) 
        {
            Interpret = interpret;
        }
        public string Interpret { get; set; }
    }
}
