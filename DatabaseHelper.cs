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
               // int i = 0;
                while (reader.Peek() >= 0)
                {
                  //  i++;
                    var line = reader.ReadLine().Split('*');
                    using (SqlCommand cmd = new SqlCommand(cmdText, con))
                    {
                        cmd.Parameters.AddWithValue("email", line[0]);
                        cmd.Parameters.AddWithValue("parola", line[1]);
                        cmd.Parameters.AddWithValue("nume", line[2]);
                        cmd.Parameters.AddWithValue("prenume", line[3]);

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
                    while (reader.Peek() >= 0)
                    {
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
            string cmdText = "Insert into imprumut (id_carte,email,data_imprumut) values (@id_carte,@email,@data_imprumut);";
            using (StreamReader reader = new StreamReader(_imprumuturiString))
            {
                string textLineFromFile;

                //while (reader.Peek() >= 0)
                while((textLineFromFile = reader.ReadLine()) != null)
                {
                    string[] line = textLineFromFile.Split('*');
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
                        cmd.Parameters.AddWithValue("id_carte", idCarte);
                        cmd.Parameters.AddWithValue("email", line[1]);
                        string date = line[2].Trim();
                        try {
                            cmd.Parameters.AddWithValue("data_imprumut", DateTime.ParseExact(date, "M/d/yyyy", CultureInfo.InvariantCulture));
                        } catch {
                            Console.WriteLine("eroare procesare pe linia " + line);
                            cmd.Parameters.AddWithValue("data_imprumut", DateTime.Now);
                        }

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


        public static void UserRegistration(UserModel user) {
            using (SqlConnection con = new SqlConnection(_connectionString)) {
                con.Open();
                string cmdText = "Insert into utilizatori (email,parola,nume,prenume) values (@email,@parola,@nume,@prenume);";

                using (SqlCommand cmd = new SqlCommand(cmdText, con)) {
                    cmd.Parameters.AddWithValue("email", user.email);
                    cmd.Parameters.AddWithValue("parola", user.parola);
                    cmd.Parameters.AddWithValue("nume", user.nume);
                    cmd.Parameters.AddWithValue("prenume", user.prenume);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static UserModel IsRegistered(string email) {
            UserModel utilizator = new UserModel();
            using (SqlConnection con = new SqlConnection(_connectionString)) {
                con.Open();
                string cmdText = "Select email,parola,nume,prenume from utilizatori where email = @email";

                using (SqlCommand cmd = new SqlCommand(cmdText, con)) {
                    cmd.Parameters.AddWithValue("email", email);

                    using (SqlDataReader rdr = cmd.ExecuteReader()) {
                        if (rdr.Read()) {
                            utilizator = new UserModel {
                                email = (string)rdr["email"],
                                parola = (string)rdr["parola"],
                                nume = (string)rdr["nume"],
                                prenume = (string)rdr["prenume"]
                            };
                        }
                    }
                }
            }

            return utilizator;
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
