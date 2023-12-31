﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Zlatno_Burence
{
    internal class CL_Magacin
    {
        //promenjive
        private int id;
        private string ime;
        private int cena;
        private int naStanju;

        //geteri i seteri
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Ime
        {
            get { return ime; }
            set
            {
                if (value == "") throw new Exception("Morate uneti ime zaposlenog!");
                ime = value;
            }
        }

        public int Cena
        {
            get { return cena; }
            set
            {
                if (value < 0) throw new Exception("Morate uneti vrednost cene koja je veća od 0");
                cena = value;
            }
        }

        public int NaStanju
        {
            get { return naStanju; }
            set
            {
                if (value < 0) throw new Exception("Morate uneti koliko pića ima na stanju a da je vrednost veća od 0");
                naStanju = value;
            }
        }

        //konekcioni string
        private string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\L\\Desktop\\faks\\si1\\semianrski\\Zlatno-Burence\\ZlatnoBurence.mdf;Integrated Security=True";

        //funkcije za manipulisanje bazom
        public void dodajPice()
        {
            string insertSql = "INSERT INTO Magacin " + "(ImePica, CenaPica, NaStanju) VALUES" + "(@Ime, @Cena, @NaStanju)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = insertSql;
                command.Parameters.Add(new SqlParameter("@Ime", Ime));
                command.Parameters.Add(new SqlParameter("@Cena", Cena));
                command.Parameters.Add(new SqlParameter("@NaStanju", NaStanju));
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void azurirajPica()
        {
            string updateSql = "UPDATE Magacin " + "SET ImePica= @Ime, CenaPica=@Cena, NaStanju= @NaStanju " + "WHERE Id = @Id;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = updateSql;
                command.Parameters.Add(new SqlParameter("@Id", ID));
                command.Parameters.Add(new SqlParameter("@Ime", Ime));
                command.Parameters.Add(new SqlParameter("@Cena", Cena));
                command.Parameters.Add(new SqlParameter("@NaStanju", NaStanju));
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void obrisiPice()
        {
            try
            {
                string deleteSql = "DELETE FROM Magacin WHERE Id = @Id;";
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = deleteSql;
                    command.Parameters.Add(new SqlParameter("@Id", ID));
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<CL_Magacin> ucitajPica()
        {
            List<CL_Magacin> pica = new List<CL_Magacin>();
            string queryString = "SELECT * FROM Magacin;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = queryString;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    CL_Magacin mag;
                    while (reader.Read())
                    {
                        mag = new CL_Magacin();
                        mag.ID = Int32.Parse(reader["Id"].ToString());
                        mag.Ime = reader["ImePica"].ToString();
                        mag.Cena = Int32.Parse(reader["CenaPica"].ToString());
                        mag.NaStanju = Int32.Parse(reader["NaStanju"].ToString());
                        pica.Add(mag);
                    }
                }
            }
            return pica;
        }
    }
}
