using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Automoto_PujcovnaProdejna
{
	public static class Databaze
	{
		public static BindingList<Zakaznik> Zakaznici { get; private set; } = [];
		public static BindingList<Vozidlo> Sklad { get; private set; } = [];
		static Databaze()
		{
			Deserializace();
		}

		public static bool Prodat(object zO, object vO)
		{
			Zakaznik z = (Zakaznik)zO;
			Vozidlo v = (Vozidlo)vO;

			if ((!z.Plnolety && (v is Vozidlo vozidlo)) || !v.Pristupne) return false;

			z.Koupene.Add(v);
			Sklad.Remove(v);

			return true;
		}

		public static bool Vypujcit(object zO, object vO)
		{
			Zakaznik z = (Zakaznik)zO;
			Vozidlo v = (Vozidlo)vO;

			if ((!z.Plnolety && (v is Vozidlo vozidlo)) || !v.Pristupne) return false;

			z.Vypujcene.Add(v);
			Sklad.Remove(v);

			return true;
		}

		public static void Vratit(object zO, object vO)
		{
			Zakaznik z = (Zakaznik)zO;
			Vozidlo v = (Vozidlo)vO;

			Sklad.Add(v);
			z.Vypujcene.Remove(v);
		}

		public static void Odkoupit(object zO, object vO)
		{
			Zakaznik z = (Zakaznik)zO;
			Vozidlo v = (Vozidlo)vO;

			Sklad.Add(v);
			z.Koupene.Remove(v);
		}


		public static void Serializace()
		{
			SerializaceXml(Zakaznici, "zakaznici.xml");
			SerializaceXml(Sklad, "sklad.xml");
		}

		public static void SerializaceXml<T>(BindingList<T> list, string soubor)
		{
			using (Stream s = File.Open(soubor, FileMode.Create))
			{
				XmlSerializer x = new XmlSerializer(typeof(BindingList<T>));
				x.Serialize(s, list);
			}
		}

		public static void Deserializace()
		{
			Zakaznici = DeserializaceXml<Zakaznik>("zakaznici.xml");
			Sklad = DeserializaceXml<Vozidlo>("sklad.xml");
		}

		public static BindingList<T> DeserializaceXml<T>(string soubor)
		{
			using (Stream s = File.Open(soubor, FileMode.Open))
			{
				XmlSerializer x = new XmlSerializer(typeof(BindingList<T>));
				return (BindingList<T>)x.Deserialize(s);
				
			}
		}
	}
}
