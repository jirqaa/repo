using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automoto_PujcovnaProdejna
{
	[Serializable()]
	public class Auto : Vozidlo
	{
		public Auto() { }
		public Auto(string nazev, string vyrobce, int cenaKoupe, int cenaVypujcky, int najeto, int rokVyroby, bool technicka, bool pristupne, int pocetDveri, string pohon) : base(nazev, vyrobce, cenaKoupe, cenaVypujcky, najeto, rokVyroby, technicka, pristupne)
		{
			PocetDveri = pocetDveri;
			Pohon = pohon;
		}
		public int PocetDveri { get; set; }
		public string Pohon { get; set; }
		public override string Typ => "Auto";
	}
}
