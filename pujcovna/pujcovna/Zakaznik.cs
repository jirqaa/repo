using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pujcovna
{
    public class Zakaznik
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Adresa { get; set; }
        public int RokNarozeni { get; set; }
        public BindingList<Disk> Vypujcujeme { get; set; } = [];

        public Zakaznik(string jmeno, string prijmeni, string adresa, int rokNarozeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Adresa = adresa;
            RokNarozeni = rokNarozeni;
        }
    }
}
