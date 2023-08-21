namespace Zlatno_Burence
{
    public partial class Prodaja : Form
    {
        public Prodaja()
        {
            InitializeComponent();
        }

        //-funkcije za prebacivanje formi
        private void nabavkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nabavka frmNabavka = new Nabavka();
            frmNabavka.Show();
        
        }

        private void zaposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zaposleni frmZaposleni = new Zaposleni();
            frmZaposleni.Show();
        }

        private void picaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pica frmPica = new Pica();
            frmPica.Show();
        }

        private void magacinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Magacin frmMagacin = new Magacin();
            frmMagacin.Show();
        }

        private void Prodaja_Load(object sender, EventArgs e)
        {

        }

       
    }
}