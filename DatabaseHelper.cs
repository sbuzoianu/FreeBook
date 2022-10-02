using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Configuration;
using System.Globalization;

namespace FreeBook
{
    class DatabaseHelper
    {
        private static string _connectionString = SqlDataAccess.GetConnectionStrings();
        private static string _cartiString = SqlDataAccess.GetCartiPathStrings();
        private static string _utilizatoriString = SqlDataAccess.GetUtilizatoriPathStrings();
        private static string _imprumuturiString = SqlDataAccess.GetImprumuturiPathStrings();


        public static void Initialisation()
        {
            ClearDatabase();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                InserareCarti(con);
                InserareUtilizatori(con);
                InserareImprumuturi(con);

            }

        }

        private static void InserareUtilizatori(SqlConnection con)
        {
            string cmdText = "Insert into utilizatori (email,parola,nume,prenume) values (@email,@parola,@nume,@prenume);";

            using (StreamReader reader = new StreamReader(_utilizatoriString))
            {
                int i = 0;
                while (reader.Peek() >= 0)
                {
                    i++;
                    var line = reader.ReadLine().Split('*');
                    using (SqlCommand cmd = new SqlCommand(cmdText, con))
                    {
                        cmd.Parameters.AddWithValue("email", i);
                        cmd.Parameters.AddWithValue("parola", line[0]);
                        cmd.Parameters.AddWithValue("nume", line[1]);
                        cmd.Parameters.AddWithValue("prenume", line[2]);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private static void InserareCarti(SqlConnection con)
        {
                string cmdText = "Insert into carti (titlu,autor,gen) values (@titlu,@autor,@gen);";

                using (StreamReader reader = new StreamReader(_cartiString))
                {
                    int i = 0;
                    while (reader.Peek() >= 0)
                    {
                        i++;
                        var line = reader.ReadLine().Split('*');
                        using (SqlCommand cmd = new SqlCommand(cmdText, con))
                        {
                            cmd.Parameters.AddWithValue("titlu", line[0]);
                            cmd.Parameters.AddWithValue("autor", line[1]);
                            cmd.Parameters.AddWithValue("gen", line[2]);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
        }


        private static void InserareImprumuturi(SqlConnection con)
        {
            string cmdText = "Insert into imprumut (id_imprumut,id_carte,email,data_imprumut) values (@id_imprumut,@id_carte,@email,@data_imprumut);";

            using (StreamReader reader = new StreamReader(_imprumuturiString))
            {
                int i = 0;
                while (reader.Peek() >= 0)
                {
                    i++;
                    var line = reader.ReadLine().Split('*');
                    int idCarte = 0;
                    using (SqlCommand cmd = new SqlCommand("Select id_carte from carti where titlu = @titlu", con))
                    {
                        cmd.Parameters.AddWithValue("titlu", line[0]);

                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            rdr.Read();
                            idCarte = (int)rdr[0];
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(cmdText, con))
                    {
                        cmd.Parameters.AddWithValue("id_imprumut", i);
                        cmd.Parameters.AddWithValue("id_carte", idCarte);
                        cmd.Parameters.AddWithValue("email", line[1]);
                        string date = line[2].Trim();
                        cmd.Parameters.AddWithValue("data_imprumut", DateTime.ParseExact(date, "M/d/yyyy", CultureInfo.InvariantCulture));

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }



        private static void ClearDatabase()
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                string cmdText = "Delete from carti";
                ExecuteSQLQuery(con, cmdText);
                cmdText = "Delete from utilizatori";
                ExecuteSQLQuery(con, cmdText);
                cmdText = "Delete from imprumut";
                ExecuteSQLQuery(con, cmdText);
            }
        }

        private static void ExecuteSQLQuery(SqlConnection con, string cmdText)
        {
            using (SqlCommand cmd = new SqlCommand(cmdText, con))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
