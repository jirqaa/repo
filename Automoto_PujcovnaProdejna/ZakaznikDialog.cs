using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automoto_PujcovnaProdejna
{
	public enum ActionType { New, Edit };
	public partial class ZakaznikDialog : Form
	{
		public ActionType Action { get; set; } = ActionType.New;
		public Zakaznik Cust { get; set; }
		public ZakaznikDialog()
		{
			InitializeComponent();
		}

		private void ZakaznikDialog_VisibleChanged(object sender, EventArgs e)
		{
			switch (Action)
			{
				case ActionType.New: //pridani noveho zakaznika
					txtJmeno.Text = string.Empty;
					txtPrijmeni.Text = string.Empty;
					txtAdresa.Text = string.Empty;
					numRok.Value = 1910;
					numCisloOp.Value = 100000000;
					txtBankovniUcet.Text = string.Empty;
					break;
				case ActionType.Edit: //editace zakaznika
					txtJmeno.Text = Cust.Jmeno;
					txtPrijmeni.Text = Cust.Prijmeni;
					txtAdresa.Text = Cust.Adresa;
					numRok.Value = Cust.RokNarozeni; 
					numCisloOp.Value = Cust.CisloOp;
					txtBankovniUcet.Text = Cust.BankovniUcet;
					break;
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			switch (Action)
			{
				case ActionType.New: //potvrzeni vytvoreni noveho zakaznika podle zadanych dat po stisknuti tlacitka OK
					Cust = new Zakaznik(txtJmeno.Text, txtPrijmeni.Text, txtAdresa.Text, (int)numRok.Value, (int)numCisloOp.Value, txtBankovniUcet.Text);
					break;
				case ActionType.Edit: //prepsani informaci stavajiciho zakaznika na upravene po stisknuti tlacitka OK
					Cust.Jmeno = txtJmeno.Text;
					Cust.Prijmeni = txtPrijmeni.Text;
					Cust.Adresa = txtAdresa.Text;
					Cust.RokNarozeni = (int)numRok.Value;
					Cust.CisloOp = (int)numCisloOp.Value;
					Cust.BankovniUcet = txtBankovniUcet.Text;
					break;
			}
		}
	}
}
