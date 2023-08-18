﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zlatno_Burence
{
    internal class CL_Nabavka
    {
        //Promenjive
        private int id;
        private int idPica;
        private int idZaposlenog;
        private int naStanju;
        private int datum;

        //-promenjive kolicina
        private int vinoBelo_kolicina;
        private int vinoCrveno_kolicina;
        private int pivoJelen05_kolicina;
        private int pivoJelen033_kolicina;
        private int jelenToceno_kolicina;
        private int jelenGrejp_kolicina;
        private int staropramen_kolicina;
        private int niksickoPivo_kolicina;
        private int niksickoTamno_kolicina;
        private int stella_kolicina;
        private int bavarija05_kolicina;
        private int bavarija025_kolicina;
        private int guarana_kolicina;
        private int cola_kolicina;
        private int sveps_kolicina;
        private int ledeniCaj_kolicina;
        private int cedevita_kolicina;
        private int negaziranaVoda_kolicina;
        private int knjaz_kolicina;
        private int jeger_kolicina;
        private int keglovic_kolicina;
        private int gorkiList_kolicina;
        private int rakijaKajsija_kolicina;
        private int rakijaDunja_kolicina;
        private int vinjak_kolicina;
        private int mentol_kolicina;
        private int kruskovac_kolicina;
        private int vodka_kolicina;
        private int kupinovoVino_kolicina;
        private int espresso_kolicina;
        private int nes_kolicina;
        private int domaca_kolicina;
        private int caj_kolicina;

        //geteri i seteri
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int NaStanju
        {
            get { return naStanju; }
            set
            {
                if (value < 0) throw new Exception("Ne može na stanju biti manje od 0 artikala!");
                naStanju = value;
            }
        }

        //konekcioni string
        private string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\L\\Desktop\\faks\\si1\\semianrski\\Zlatno-Burence\\ZlatnoBurence.mdf;Integrated Security=True";
        
        //Funkcioje
        //-funkcije za manipulisanje bazom
        public void azurirajNaStanjuPica()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString)) 
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Pica";
                 using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                   DataTable dataTable = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand)) 
                    {
                        adapter.Fill(dataTable);
                    }

                    foreach (DataRow row in dataTable.Rows) 
                    {
                        int trenutnaVrednost = Convert.ToInt32(row["NaStanju"]);
                        int novaVrednost = trenutnaVrednost + 100;
                        row["NaStanju"] = novaVrednost; 
                    }

                    string updateQuery = "UPDATE Pica SET NaStanju= @NovaVrednost WHERE Id = @Id;";
                    foreach (DataRow row in dataTable.Rows) 
                    {
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection)) 
                        {
                            updateCommand.Parameters.AddWithValue("@Id", row["Id"]);
                            updateCommand.Parameters.AddWithValue("@NovaVrednost", row["NaStanju"]);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                }
                
            }
        }
    }

}