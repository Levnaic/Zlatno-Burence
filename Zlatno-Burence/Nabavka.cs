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

        private void magacinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Magacin frmMagacin = new Magacin();
            frmMagacin.Show();

        }

        //-funkcije za dugmad

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            CL_Nabavka nab = new CL_Nabavka();
            nab.azurirajNaStanjuPica();
        }

        private void ocistiFormu() 
        {
            txtVinoBelo.Text = "";
            txtVinoCrveno.Text = "";
            txtPivoJelen033.Text = "";
            txtPivoJelen05.Text = "";
            txtJelenToceno05.Text = "";
            txtJelenGrejp.Text = "";
            txtStaropramen.Text = "";
            txtNiksickoPivo.Text = "";
            txtNiksickoTamno.Text = "";
            txtStella.Text = "";
            txtBavarijaTocena025.Text = "";
            txtCaj.Text = "";
            txtCedevita.Text = "";
            txtCola.Text = "";
            txtDomacaKafa.Text = "";
            txtEspesso.Text = "";
            txtGorki.Text = "";
            txtGuarana.Text = "";
            txtJeger.Text = "";
            txtKeglovic.Text = "";
            txtKruskovac.Text = "";
            txtKupinovoVino.Text = "";
            txtLedeniCaj.Text = "";
            txtMentol.Text = "";
            txtNegaziranaVoda.Text = "";
            txtNesKafa.Text = "";
            txtRakijaDunja.Text = "";
            txtRakijaKajsija.Text = "";
            txtSveps.Text = "";
            txtVinjakRubin.Text = "";
            txtVodaKnjaz.Text = "";
            txtVodka.Text = "";
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            ocistiFormu();
        }
    }
}
