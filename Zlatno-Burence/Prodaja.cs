namespace Zlatno_Burence
{
    public partial class Prodaja : Form
    {
        public Prodaja()
        {
            InitializeComponent();
        }

        private void nabavkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nabavka frmNabavka = new Nabavka();
            frmNabavka.ShowDialog();
        
        }

        private void zaposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zaposleni frmZaposleni = new Zaposleni(); ;
            frmZaposleni.ShowDialog();
        }
    }
}