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
            dgPica.Columns.Add("naStanju", "NaStanju");

            prikazPicaDGV();

        }

        private void prikaziPiceTxt() 
        {
            int idSelektovanog = (int)dgPica.SelectedRows[0].Cells["ID"].Value;
            CL_Pica selektovanoPice = picaList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
            if (selektovanoPice != null)
            {
                txtImePica.Text = selektovanoPice.Ime;
                //treba se nastaviti sa txt poljima ali se nailazi na neki error, tu si stao 
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
                dgPica.Rows[i].Cells["NaStanju"].Value = picaList[i].NaStanju;

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
    }
}
