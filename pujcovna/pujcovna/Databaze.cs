using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pujcovna
{
    public static class Databaze
    {
        public static BindingList<Zakaznik> Zakaznici { get; private set; } = [];
        public static BindingList<Disk> Sklad { get; private set; } = [];
        static Databaze()
        {
            Zakaznici.Add(new Zakaznik("Pepa", "Novak", "Praha", 1919));
            Zakaznici.Add(new Zakaznik("Pavel", "Hluchy", "Pribram", 1929));
            Zakaznici.Add(new Zakaznik("Jan", "Slepy", "Misov", 1939));
            Zakaznici.Add(new Zakaznik("Kook", "TheCrook", "Pardubice", 2020));

            Sklad.Add(new CD("BOOOM", "rock", 16, "peepoo"));
            Sklad.Add(new CD("Rosenrot", "metal", 20, "ramstein"));
            Sklad.Add(new CD("Black Ice", "rock", 24, "AC/DC"));
            Sklad.Add(new CD("BOOOMshakalaka", "altrock", 30, "Bebb"));

            Sklad.Add(new DVD("sw", "scifi", 30, "gerg elucas", "a", false));
            Sklad.Add(new DVD("swa", "scif", 30, "gerg e", "b", false));
            Sklad.Add(new DVD("swan", "sci", 30, "gerg eluc", "c", false));
            Sklad.Add(new DVD("swank", "scifasdi", 30, "gerg elucassadfs", "d", false));
        }
    }
}
