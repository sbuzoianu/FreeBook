using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Configuration;


namespace FreeBook
{
    class DatabaseHelper
    {
        private static string _connectionString = SqlDataAccess.GetConnectionStrings();
        private static string _cartiString = SqlDataAccess.GetCartiPathStrings();

        public static void Initialisation()
        {
            ClearDatabase();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

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
