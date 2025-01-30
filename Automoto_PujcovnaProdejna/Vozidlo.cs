using System;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Automoto_PujcovnaProdejna
{
	[Serializable(), XmlInclude(typeof(Auto)), XmlInclude(typeof(Moto))]
	public abstract class Vozidlo : INotifyPropertyChanged
	{
		private string _nazev;
		private string _vyrobce;
		private int _cenaKoupe;
		private int _cenaVypujcky;
		private int _najeto;
		private int _rokVyroby;
		private bool _technicka;
		private bool _pristupne;
		public string Nazev 
		{
			get => _nazev;
			set
			{
				if (_nazev != value)
				{
					_nazev = value;
					NotifyPropertyChanged();
				}
			}
		}
		public string Vyrobce
		{
			get => _vyrobce;
			set
			{
				if (_vyrobce != value)
				{
					_vyrobce = value;
					NotifyPropertyChanged();
				}
			}
		}
		public int CenaKoupe
		{
			get => _cenaKoupe;
			set
			{
				if (_cenaKoupe != value)
				{
					_cenaKoupe = value;
					NotifyPropertyChanged();
				}
			}
		}
		public int CenaVypujcky
		{
			get => _cenaVypujcky;
			set
			{
				if (_cenaVypujcky != value)
				{
					_cenaVypujcky = value;
					NotifyPropertyChanged();
				}
			}
		}
		public int Najeto
		{
			get => _najeto;
			set
			{
				if (_najeto != value)
				{
					_najeto = value;
					NotifyPropertyChanged();
				}
			}
		}
		public int RokVyroby
		{
			get => _rokVyroby;
			set
			{
				if (_rokVyroby != value)
				{
					_rokVyroby = value;
					NotifyPropertyChanged();
				}
			}
		}
		public bool Technicka
		{
			get => _technicka;
			set
			{
				if (_technicka != value)
				{
					_technicka = value;
					NotifyPropertyChanged();
				}
			}
		}
		public bool Pristupne
		{
			get => _pristupne;
			set
			{
				if (_pristupne != value)
				{
					_pristupne = value;
					NotifyPropertyChanged();
				}
			}
		}
		public abstract string Typ { get; }
		public Vozidlo() { }
		public Vozidlo(string nazev, string vyrobce, int cenaKoupe, int cenaVypujcky, int najeto, int rokVyroby, bool technicka, bool pristupne = true)
		{
			Nazev = nazev;
			Vyrobce = vyrobce;
			CenaKoupe = cenaKoupe;
			CenaVypujcky = cenaVypujcky;
			Najeto = najeto;
			RokVyroby = rokVyroby;
			Technicka = technicka;
			Pristupne = pristupne;
		}

		private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
