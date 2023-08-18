using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zlatno_Burence
{
    public partial class Nabavka : Form
    {
        public Nabavka()
        {
            InitializeComponent();
        }

        //load funkcija
        private void Nabavka_Load(object sender, EventArgs e)
        {
        

        }

        //-funkcije za prebacivanje formi
        private void prodajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Prodaja frmProdaja = new Prodaja(); ;
            frmProdaja.Show();
        }

        private void zaposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Zaposleni frmZaposleni = new Zaposleni(); ;
            frmZaposleni.Show();
        }
        private void picaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Pica frmPica = new Pica();
            frmPica.Show();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            CL_Nabavka nab = new CL_Nabavka();
            nab.azurirajNaStanjuPica();
        }
    }
}
