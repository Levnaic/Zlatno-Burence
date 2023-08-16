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
        List<Zaposleni_CL> zaposleniList = new List<Zaposleni_CL>();
        int indeksSelektovanog = 1;



        public Zaposleni()
        {
            InitializeComponent();

            ZaposleniDg.AllowUserToAddRows= false;
            ZaposleniDg.AllowUserToDeleteRows= false;
            ZaposleniDg.ReadOnly= true;
            ZaposleniDg.AutoGenerateColumns= false;
            ZaposleniDg.Columns.Add("ID", "ID");
            ZaposleniDg.Columns["ID"].Visible= false;
            ZaposleniDg.Columns.Add("ime", "Ime");
            ZaposleniDg.Columns.Add("prezime", "Prezime");
        }

        private void prikazZaposlenigDGV() 
        {
            zaposleniList = new Zaposleni_CL().ucitajZaposlene();
            ZaposleniDg.Rows.Clear();
            for (int i = 0; i < zaposleniList.Count; i++) 
            {
                ZaposleniDg.Rows.Add();
                ZaposleniDg.Rows[i].Cells["ID"].Value = zaposleniList[i].ID;
                ZaposleniDg.Rows[i].Cells["Ime"].Value = zaposleniList[i].Ime;
                ZaposleniDg.Rows[i].Cells["Prezime"].Value = zaposleniList[i].Prezime;

            }

            ZaposleniDg.CurrentCell= null;
        }

        private void nabavkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nabavka frmNabavka = new Nabavka();
            frmNabavka.ShowDialog();

        }

        private void prodajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prodaja frmProdaja = new Prodaja(); ;
            frmProdaja.ShowDialog();
        }

        private void dodajZapBtn_Click(object sender, EventArgs e)
        {
            Zaposleni_CL zap = new Zaposleni_CL();
            zap.Ime = imeZapTxt.Text;
            zap.Prezime = PrezZapTxt.Text;
            zap.dodajZaposlenog();
            indeksSelektovanog = ZaposleniDg.Rows.Count;

        }

        private void Zaposleni_Load(object sender, EventArgs e)
        {

        }
    }
}
