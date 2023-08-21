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
    public partial class Pica : Form
    {
        //Promenjive
        List<CL_Pica> picaList = new List<CL_Pica>();
        int indeksSelektovanog = -1;

        public Pica()
        {
            InitializeComponent();

            dgPica.AllowUserToAddRows= false;
            dgPica.AllowUserToDeleteRows= false;
            dgPica.ReadOnly = true;
            dgPica.AutoGenerateColumns=false;
            dgPica.Columns.Add("ID", "ID");
            dgPica.Columns["ID"].Visible=false;
            dgPica.Columns.Add("ime", "Ime");
            dgPica.Columns.Add("cena", "Cena");

            prikazPicaDGV();

        }

        //FUNKCIJE

        private void prikaziPiceTxt() 
        {
            int idSelektovanog = (int)dgPica.SelectedRows[0].Cells["ID"].Value;
            CL_Pica selektovanoPice = picaList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
            if (selektovanoPice != null)
            {
                txtImePica.Text = selektovanoPice.Ime;
                txtCenaPica.Text = selektovanoPice.Cena.ToString();
                //mozda nije tacno
            }
        }

        private void prikazPicaDGV() 
        {
            picaList = new CL_Pica().ucitajPica();
            dgPica.Rows.Clear();
            for (int i = 0; i < picaList.Count; i++)
            {
                dgPica.Rows.Add();
                dgPica.Rows[i].Cells["ID"].Value = picaList[i].ID;
                dgPica.Rows[i].Cells["Ime"].Value = picaList[i].Ime;
                dgPica.Rows[i].Cells["Cena"].Value = picaList[i].Cena;

            }

            dgPica.CurrentCell = null;

            if (picaList.Count > 0)
            {
                if (indeksSelektovanog != -1) dgPica.Rows[indeksSelektovanog].Selected = true;
                else dgPica.Rows[0].Selected = true;
                prikaziPiceTxt();
            }

        }

        private void Pica_Load(object sender, EventArgs e)
        {

        }

        //-funkcije za prebacivanje formi
        private void nabavkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Nabavka frmNabavka = new Nabavka();
            frmNabavka.Show();
        }

        private void prodajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Prodaja frmProdaja = new Prodaja(); ;
            frmProdaja.Show();
        }

        private void zaposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Zaposleni frmProdaja = new Zaposleni(); ;
            frmProdaja.Show();
        }

        private void magacinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Magacin frmMagacin = new Magacin();
            frmMagacin.Show();
        }

        //-funkcije za dugmad
        private void btnDodajPice_Click(object sender, EventArgs e)
        {
            CL_Pica pic = new CL_Pica();
            pic.Ime = txtImePica.Text;
            pic.Cena = Int32.Parse(txtCenaPica.Text);
            pic.dodajPice();
            indeksSelektovanog = dgPica.Rows.Count;
            prikazPicaDGV();
        }


        private void btnObrisiPice_Click(object sender, EventArgs e)
        {
            if (dgPica.SelectedRows.Count > 0) 
            {
                if (MessageBox.Show("Da li zelite da obrisete odabrano pice?", "Potvrda brisanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idSelektovanog = (int)dgPica.SelectedRows[0].Cells["ID"].Value;
                    CL_Pica selektovanoPice = picaList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
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

        private void btnAzurirajPice_Click(object sender, EventArgs e)
        {
            if (dgPica.SelectedRows.Count > 0)
            {
                int idSelektovanog = (int)dgPica.SelectedRows[0].Cells["ID"].Value;
                CL_Pica selektovanoPice = picaList.Where(x => x.ID == idSelektovanog).FirstOrDefault();

                if (selektovanoPice != null)
                {
                    selektovanoPice.Ime = txtImePica.Text;
                    selektovanoPice.Cena = Int32.Parse(txtCenaPica.Text);
                    selektovanoPice.azurirajPica();
                    indeksSelektovanog = dgPica.SelectedRows[0].Index;

                    prikazPicaDGV();
                }

            }
            else
            {
                MessageBox.Show("Nema podataka ili ni jedan red nije odabran!");
            }
        }

        //-funkcija za dg
        private void dgPica_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPica.CurrentRow != null)
            {
                dgPica.Rows[dgPica.CurrentRow.Index].Selected = true;
                prikaziPiceTxt();
            }
        }

        

        
    }
}
