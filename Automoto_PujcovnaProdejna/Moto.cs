using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automoto_PujcovnaProdejna
{
	[Serializable()]
	public class Moto : Vozidlo
	{
		public Moto() { }
		public Moto(string nazev, string vyrobce, int cenaKoupe, int cenaVypujcky, int najeto, int rokVyroby, bool technicka, bool pristupne, int objemMotoru, bool retez) : base(nazev, vyrobce, cenaKoupe, cenaVypujcky, najeto, rokVyroby, technicka, pristupne)
		{
			ObjemMotoru = objemMotoru;
			Retez = retez;
		}
		public int ObjemMotoru { get; set; }
		public bool Retez { get; set; }
		public override string Typ => "Moto";
	}
}
