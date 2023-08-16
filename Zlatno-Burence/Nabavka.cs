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

        private void prodajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prodaja frmProdaja = new Prodaja(); ;
            frmProdaja.ShowDialog();
        }

        private void zaposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zaposleni frmZaposleni = new Zaposleni(); ;
            frmZaposleni.ShowDialog();
        }
    }
}
