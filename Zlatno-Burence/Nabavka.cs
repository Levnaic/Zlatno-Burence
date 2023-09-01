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
        //promenjive
        int[] picaKolicina = new int[50];

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
            picaKolicina[0] = Int32.Parse(txtVinoBelo.Text);
            picaKolicina[1] = Int32.Parse(txtVinoCrveno.Text);
            picaKolicina[2] = Int32.Parse(txtPivoJelen05.Text);
            picaKolicina[3] = Int32.Parse(txtPivoJelen033.Text);
            picaKolicina[4] = Int32.Parse(txtJelenToceno05.Text);
            picaKolicina[5] = Int32.Parse(txtJelenGrejp.Text);
            picaKolicina[6] = Int32.Parse(txtStaropramen.Text);
            picaKolicina[7] = Int32.Parse(txtNiksickoPivo.Text);
            picaKolicina[8] = Int32.Parse(txtNiksickoTamno.Text);
            picaKolicina[9] = Int32.Parse(txtStella.Text);
            picaKolicina[10] = Int32.Parse(txtBavarijaTocena025.Text);
            picaKolicina[11] = Int32.Parse(txtGuarana.Text);
            picaKolicina[12] = Int32.Parse(txtCola.Text);
            picaKolicina[13] = Int32.Parse(txtSveps.Text);
            picaKolicina[14] = Int32.Parse(txtLedeniCaj.Text);
            picaKolicina[15] = Int32.Parse(txtCedevita.Text);
            picaKolicina[16] = Int32.Parse(txtNegaziranaVoda.Text);
            picaKolicina[17] = Int32.Parse(txtVodaKnjaz.Text);
            picaKolicina[18] = Int32.Parse(txtJeger.Text);
            picaKolicina[19] = Int32.Parse(txtKeglovic.Text);
            picaKolicina[20] = Int32.Parse(txtGorki.Text);
            picaKolicina[21] = Int32.Parse(txtRakijaKajsija.Text);
            picaKolicina[22] = Int32.Parse(txtRakijaDunja.Text);
            picaKolicina[23] = Int32.Parse(txtVinjakRubin.Text);
            picaKolicina[24] = Int32.Parse(txtMentol.Text);
            picaKolicina[25] = Int32.Parse(txtKruskovac.Text);
            picaKolicina[26] = Int32.Parse(txtVodka.Text);
            picaKolicina[27] = Int32.Parse(txtKupinovoVino.Text);
            picaKolicina[28] = Int32.Parse(txtEspesso.Text);
            picaKolicina[29] = Int32.Parse(txtNesKafa.Text);
            picaKolicina[30] = Int32.Parse(txtDomacaKafa.Text);
            picaKolicina[31] = Int32.Parse(txtCaj.Text);


            CL_Nabavka nab = new CL_Nabavka();
            nab.azurirajNaStanjuPica(picaKolicina);

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
