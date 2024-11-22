namespace pujcovna
{
    public partial class Pujcovna : Form
    {
        public Pujcovna()
        {
            InitializeComponent();
            dgvSklad.DataSource = Databaze.Sklad;
            dgvZakaznici.DataSource = Databaze.Zakaznici;
        }

        private void btnVypujcit_Click(object sender, EventArgs e)
        {

        }
    }
}
