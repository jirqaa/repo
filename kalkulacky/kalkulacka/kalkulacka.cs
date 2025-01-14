namespace kalkulacka
{
    public partial class Kalkulacka : Form
    {
        public Kalkulacka()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            textVysledek.Text = Convert.ToString(Convert.ToInt32(textHodnotaA.Text) + Convert.ToInt32(textHodnotaB.Text));
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            textVysledek.Text = Convert.ToString(Convert.ToInt32(textHodnotaA.Text) - Convert.ToInt32(textHodnotaB.Text));
        }

        private void btnDeleni_Click(object sender, EventArgs e)
        {
            textVysledek.Text = Convert.ToString(Convert.ToDouble(textHodnotaA.Text) / Convert.ToDouble(textHodnotaB.Text));
        }

        private void btnNasobeni_Click(object sender, EventArgs e)
        {
            textVysledek.Text = Convert.ToString(Convert.ToInt32(textHodnotaA.Text) * Convert.ToInt32(textHodnotaB.Text));
        }

        private void textHodnotaA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textHodnotaB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textVysledek_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
