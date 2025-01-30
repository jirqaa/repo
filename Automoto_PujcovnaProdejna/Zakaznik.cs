using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Automoto_PujcovnaProdejna
{
	[Serializable()]
	public class Zakaznik : INotifyPropertyChanged
	{
		private string _jmeno;
		private string _prijmeni;
		private string _adresa;
		private int _rokNarozeni;
		private int _cisloOp;
		private string _bankovniUcet;

		public string Jmeno
		{
			get => _jmeno;
			set
			{
				if (_jmeno != value)
				{
					_jmeno = value;
					NotifyPropertyChanged();
				}
			}
		}
		public string Prijmeni
		{
			get => _prijmeni;
			set
			{
				if (_prijmeni != value)
				{
					_prijmeni = value;
					NotifyPropertyChanged();
				}
			}
		}
		public string Adresa
		{
			get => _adresa;
			set
			{
				if (_adresa != value)
				{
					_adresa = value;
					NotifyPropertyChanged();
				}
			}
		}
		public int RokNarozeni
		{
			get => _rokNarozeni;
			set
			{
				if (_rokNarozeni != value)
				{
					_rokNarozeni = value;
					NotifyPropertyChanged();
					NotifyPropertyChanged("Plnolety");
				}
			}
		}
		public int CisloOp
		{
			get => _cisloOp;
			set
			{
				if (_cisloOp != value)
				{
					_cisloOp = value;
					NotifyPropertyChanged();
				}
			}
		}
		public string BankovniUcet
		{
			get => _bankovniUcet;
			set
			{
				if (_bankovniUcet != value)
				{
					_bankovniUcet = value;
					NotifyPropertyChanged();
				}
			}
		}
		public bool Plnolety => (DateTime.Today.Year) - RokNarozeni >= 18;
		public BindingList<Vozidlo> Vypujcene { get; private set; } = [];
		public BindingList<Vozidlo> Koupene { get; private set; } = [];
		public Zakaznik() { }
		public Zakaznik(string jmeno, string prijmeni, string adresa, int rokNarozeni, int cisloOp, string bankovniUcet)
		{
			Jmeno = jmeno;
			Prijmeni = prijmeni;
			Adresa = adresa;
			RokNarozeni = rokNarozeni;
			CisloOp = cisloOp;
			BankovniUcet = bankovniUcet;
		}

		private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public event PropertyChangedEventHandler? PropertyChanged;
	}
}