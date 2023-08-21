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
    public partial class Magacin : Form
    {

        //Promenjive
        List<CL_Magacin> picaList = new List<CL_Magacin>();
        int indeksSelektovanog = -1;

        public Magacin()
        {
            InitializeComponent();

            dgMagacin.AllowUserToAddRows = false;
            dgMagacin.AllowUserToDeleteRows = false;
            dgMagacin.ReadOnly = true;
            dgMagacin.AutoGenerateColumns = false;
            dgMagacin.Columns.Add("ID", "ID");
            dgMagacin.Columns["ID"].Visible = false;
            dgMagacin.Columns.Add("ime", "Ime");
            dgMagacin.Columns.Add("cena", "Cena");
            dgMagacin.Columns.Add("naStanju", "Na Stanju");

            prikazPicaDGV();
        }

        //FUNKCIJE

        //-funkcija za prebacivanje formi
        private void nabavkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Nabavka frmNabavka = new Nabavka();
            frmNabavka.Show();
        }

        private void prodajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Prodaja frmProdaja = new Prodaja();
            frmProdaja.Show();
        }

        private void zaposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Zaposleni frmZaposleni = new Zaposleni();
            frmZaposleni.Show();
        }

        private void pićaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Pica frmPica = new Pica();
            frmPica.Show();
        }

        //-funkcije za prikaz/DG

        private void prikaziPiceTxt()
        {
            int idSelektovanog = (int)dgMagacin.SelectedRows[0].Cells["ID"].Value;
            CL_Magacin selektovanoPice = picaList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
            if (selektovanoPice != null)
            {
                txtImePica.Text = selektovanoPice.Ime;
                txtCenaPica.Text = selektovanoPice.Cena.ToString();
                txtNaStanju.Text = selektovanoPice.NaStanju.ToString();
            }
        }

        private void prikazPicaDGV()
        {
            picaList = new CL_Magacin().ucitajPica();
            dgMagacin.Rows.Clear();
            for (int i = 0; i < picaList.Count; i++)
            {
                dgMagacin.Rows.Add();
                dgMagacin.Rows[i].Cells["ID"].Value = picaList[i].ID;
                dgMagacin.Rows[i].Cells["Ime"].Value = picaList[i].Ime;
                dgMagacin.Rows[i].Cells["Cena"].Value = picaList[i].Cena;
                dgMagacin.Rows[i].Cells["NaStanju"].Value = picaList[i].NaStanju;

            }

            dgMagacin.CurrentCell = null;

            if (picaList.Count > 0)
            {
                if (indeksSelektovanog != -1) dgMagacin.Rows[indeksSelektovanog].Selected = true;
                else dgMagacin.Rows[0].Selected = true;
                prikaziPiceTxt();
            }

        }

        private void dgMagacin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgMagacin.CurrentRow != null)
            {
                dgMagacin.Rows[dgMagacin.CurrentRow.Index].Selected = true;
                prikaziPiceTxt();
            }
        }

        //-funkcije za dugmad
        private void btnDodajPice_Click(object sender, EventArgs e)
        {
            CL_Magacin mag = new CL_Magacin();
            mag.Ime = txtImePica.Text;
            mag.Cena = Int32.Parse(txtCenaPica.Text);
            mag.NaStanju = Int32.Parse(txtNaStanju.Text);
            mag.dodajPice();
            indeksSelektovanog = dgMagacin.Rows.Count;
            prikazPicaDGV();
        }

        private void btnAzurirajPice_Click(object sender, EventArgs e)
        {
            if (dgMagacin.SelectedRows.Count > 0)
            {
                int idSelektovanog = (int)dgMagacin.SelectedRows[0].Cells["ID"].Value;
                CL_Magacin selektovanoPice = picaList.Where(x => x.ID == idSelektovanog).FirstOrDefault();

                if (selektovanoPice != null)
                {
                    selektovanoPice.Ime = txtImePica.Text;
                    selektovanoPice.Cena = Int32.Parse(txtCenaPica.Text);
                    selektovanoPice.NaStanju = Int32.Parse(txtNaStanju.Text);
                    selektovanoPice.azurirajPica();
                    indeksSelektovanog = dgMagacin.SelectedRows[0].Index;

                    prikazPicaDGV();
                }

            }
            else
            {
                MessageBox.Show("Nema podataka ili ni jedan red nije odabran!");
            }
        }

        private void btnObrisiPice_Click(object sender, EventArgs e)
        {
            if (dgMagacin.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Da li zelite da obrisete odabrano pice?", "Potvrda brisanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idSelektovanog = (int)dgMagacin.SelectedRows[0].Cells["ID"].Value;
                    CL_Magacin selektovanoPice = picaList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
                    if (selektovanoPice != null)
                    {
                        selektovanoPice.obrisiPice();
                    }

                    indeksSelektovanog = -1;
                    prikazPicaDGV();
                }
                else
                {
                    MessageBox.Show("Nema podataka ili ni jedan red nije odabran!");
                }
            }
        }

        private void Magacin_Load(object sender, EventArgs e)
        {

        }

      
    }
}
