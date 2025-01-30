namespace Automoto_PujcovnaProdejna
{
	public partial class PujcovnaProdejna : Form
	{
		ZakaznikDialog zakDialog = new ZakaznikDialog();
		public PujcovnaProdejna()
		{
			InitializeComponent();

			dgvZakaznici.DataSource = Databaze.Zakaznici;
			dgvSklad.DataSource = Databaze.Sklad;
		}

		private void SetButtons()
		{
			btnProdat.Enabled = dgvSklad.Rows.Count > 0;
			btnVypujcit.Enabled = dgvSklad.Rows.Count > 0;
			btnVratit.Enabled = dgvVypujcky.Rows.Count > 0;
			btnOdkup.Enabled = dgvProdeje.Rows.Count > 0;
		}

		private void btnProdat_Click(object sender, EventArgs e)
		{
			if (!Databaze.Prodat(dgvZakaznici.CurrentRow.DataBoundItem,
								  dgvSklad.CurrentRow.DataBoundItem))
				MessageBox.Show("Tento zákazník si tuto položku nemùže koupit nebo vozidlo není pøístupné.");
			SetButtons();
		}

		private void btnVypujcit_Click(object sender, EventArgs e)
		{
			if (!Databaze.Vypujcit(dgvZakaznici.CurrentRow.DataBoundItem,
								  dgvSklad.CurrentRow.DataBoundItem))
				MessageBox.Show("Tento zákazník si tuto položku nemùže vypùjèit nebo vozidlo není pøístupné.");
			SetButtons();
		}

		private void btnVratit_Click(object sender, EventArgs e)
		{
			Databaze.Vratit(dgvZakaznici.CurrentRow.DataBoundItem,
							dgvVypujcky.CurrentRow.DataBoundItem);
			SetButtons();
		}
		private void btnOdkup_Click(object sender, EventArgs e)
		{
			Databaze.Odkoupit(dgvZakaznici.CurrentRow.DataBoundItem,
							dgvProdeje.CurrentRow.DataBoundItem);
			SetButtons();
		}

		private void dgvZakaznici_SelectionChanged(object sender, EventArgs e)
		{
			dgvVypujcky.DataSource = ((Zakaznik)dgvZakaznici.CurrentRow.DataBoundItem).Vypujcene;
			dgvProdeje.DataSource = ((Zakaznik)dgvZakaznici.CurrentRow.DataBoundItem).Koupene;

			SetButtons();
		}

		private void PujcovnaProdejna_FormClosed(object sender, FormClosedEventArgs e)
		{
			Databaze.Serializace();
		}

		private void btnNovyZakaznik_Click(object sender, EventArgs e)
		{
			zakDialog.Action = ActionType.New;
			if (zakDialog.ShowDialog() == DialogResult.OK) //pouze pridani zakaznika po stisknuti tlacitka OK, jinak nic
			{
				Databaze.Zakaznici.Add(zakDialog.Cust);
			}
		}

		private void btnEditace_Click(object sender, EventArgs e)
		{
			zakDialog.Action = ActionType.Edit;
			zakDialog.Cust = (Zakaznik)dgvZakaznici.CurrentRow.DataBoundItem;
			zakDialog.ShowDialog();
		}
	}
}
