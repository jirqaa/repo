using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pujcovna
{
    public class DVD : Disk
    {
        public DVD(string nazev, string zanr, int cena, string interpret, string reziser, bool pristupny) : base(nazev, zanr, cena)
        {
            Reziser = reziser;
            Pristupny = pristupny;
        }
        public string Reziser { get; set; }
        public bool Pristupny { get; set; }
    }
}
