using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace FreeBook.DataAccess {
    class BibliotecaCartiFromDatabase {

        private static readonly string _connectionString = SqlDataAccess.GetConnectionStrings();

        public static DataTable GetDataToTable() {

            DataTable imprumuturiDataTable = new DataTable();

            imprumuturiDataTable.Columns.Add("id_carte");
            imprumuturiDataTable.Columns.Add("titlu");
            imprumuturiDataTable.Columns.Add("autor");
            imprumuturiDataTable.Columns.Add("gen");

            using (SqlConnection con = new SqlConnection(_connectionString)) {
                con.Open();
                string cmdText = "Select * from carti";
                using (SqlCommand cmd = new SqlCommand(cmdText, con)) {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd)) {
                        sda.Fill(imprumuturiDataTable);
                    }
                }
            }

            return imprumuturiDataTable;
        }
    }
}
