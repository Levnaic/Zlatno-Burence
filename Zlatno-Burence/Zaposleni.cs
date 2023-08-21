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
    public partial class Zaposleni : Form
    {
        //Promenjive
        List<CL_Zaposleni> zaposleniList = new List<CL_Zaposleni>();
        int indeksSelektovanog = -1;



        public Zaposleni()
        {
            InitializeComponent();

            ZaposleniDg.AllowUserToAddRows = false;
            ZaposleniDg.AllowUserToDeleteRows = false;
            ZaposleniDg.ReadOnly = true;
            ZaposleniDg.AutoGenerateColumns = false;
            ZaposleniDg.Columns.Add("ID", "ID");
            ZaposleniDg.Columns["ID"].Visible = false;
            ZaposleniDg.Columns.Add("ime", "Ime");
            ZaposleniDg.Columns.Add("prezime", "Prezime");

            prikazZaposlenigDGV();
        }

        //Funkcije

        private void prikaziZaposlenogTxt() 
        {
            int idSelektovanog = (int)ZaposleniDg.SelectedRows[0].Cells["ID"].Value;
            CL_Zaposleni selektovaniZaposleni = zaposleniList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
            if (selektovaniZaposleni!= null )
            {
                imeZapTxt.Text = selektovaniZaposleni.Ime;
                PrezZapTxt.Text = selektovaniZaposleni.Prezime;
            }
        }


        private void prikazZaposlenigDGV()
        {
            zaposleniList = new CL_Zaposleni().ucitajZaposlene();
            ZaposleniDg.Rows.Clear();
            for (int i = 0; i < zaposleniList.Count; i++)
            {
                ZaposleniDg.Rows.Add();
                ZaposleniDg.Rows[i].Cells["ID"].Value = zaposleniList[i].ID;
                ZaposleniDg.Rows[i].Cells["Ime"].Value = zaposleniList[i].Ime;
                ZaposleniDg.Rows[i].Cells["Prezime"].Value = zaposleniList[i].Prezime;

            }

            ZaposleniDg.CurrentCell = null;

            if (zaposleniList.Count > 0) 
            {
                if (indeksSelektovanog != -1) ZaposleniDg.Rows[indeksSelektovanog].Selected = true;
                else ZaposleniDg.Rows[0].Selected = true;
                prikaziZaposlenogTxt();
            }
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
            Prodaja frmProdaja = new Prodaja();
            frmProdaja.Show();
        }
        private void pićaToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void dodajZapBtn_Click(object sender, EventArgs e)
        {
            CL_Zaposleni zap = new CL_Zaposleni();
            zap.Ime = imeZapTxt.Text;
            zap.Prezime = PrezZapTxt.Text;
            zap.dodajZaposlenog();
            indeksSelektovanog = ZaposleniDg.Rows.Count;
            prikazZaposlenigDGV();

        }

        private void Zaposleni_Load(object sender, EventArgs e)
        {

        }

        private void obrisiBtn_Click(object sender, EventArgs e)
        {
            if (ZaposleniDg.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Da li zelite da obrisete odabranog zaposlenog?", "Potvrda brisanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idSelektovanog = (int)ZaposleniDg.SelectedRows[0].Cells["ID"].Value;
                    CL_Zaposleni selektovaniZaposleni = zaposleniList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
                    if (selektovaniZaposleni != null) 
                    {
                        selektovaniZaposleni.obrisiZaposlenog();
                    }

                    indeksSelektovanog = -1;
                    prikazZaposlenigDGV();
                } 
                else 
                {
                    MessageBox.Show("Nema podataka ili ni jedan red nije odabran!");
                }
            }
        }

        private void azurirajBtn_Click(object sender, EventArgs e)
        {
            if (ZaposleniDg.SelectedRows.Count > 0)
            {
                int idSelektovanog = (int)ZaposleniDg.SelectedRows[0].Cells["ID"].Value;
                CL_Zaposleni selektovaniZaposleni = zaposleniList.Where(x => x.ID == idSelektovanog).FirstOrDefault();

                if (selektovaniZaposleni != null)
                {
                    selektovaniZaposleni.Ime = imeZapTxt.Text;
                    selektovaniZaposleni.Prezime = PrezZapTxt.Text;
                    selektovaniZaposleni.azurirajZaposlenog();
                    indeksSelektovanog = ZaposleniDg.SelectedRows[0].Index;

                    prikazZaposlenigDGV();
                }

            }
            else
            {
                MessageBox.Show("Nema podataka ili ni jedan red nije odabran!");
            }
        }

        //-funkcije za dg
        private void ZaposleniDg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ZaposleniDg.CurrentRow != null)
            {
                ZaposleniDg.Rows[ZaposleniDg.CurrentRow.Index].Selected = true;
                prikaziZaposlenogTxt();
            }

        }

      

        private void ZaposleniDg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
