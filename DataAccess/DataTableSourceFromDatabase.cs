using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using FreeBook.Models;

namespace FreeBook.DataAccess {
    class DataTableSourceFromDatabase {

        private static readonly string _connectionString = SqlDataAccess.GetConnectionStrings();
        private static List<ImprumutCarteModel> cartiImprumutate;

        public static DataTable GetAllAvailableBooksIntoDataTable() {

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

        public static DataTable GetAllAssignedBooksIntoDataTable(UserModel utilizator) {

            cartiImprumutate = DatabaseHelper.GetCartiImprumutateDeUtilizator(utilizator);
            cartiImprumutate = cartiImprumutate.OrderByDescending(x => x.DataImprumut).ToList();
            

            DataTable cartiImprumutatedeUtilizatorDataTable = new DataTable();
            cartiImprumutatedeUtilizatorDataTable.Columns.Add("Index");
            cartiImprumutatedeUtilizatorDataTable.Columns.Add("Titlu");
            cartiImprumutatedeUtilizatorDataTable.Columns.Add("Autor");
            cartiImprumutatedeUtilizatorDataTable.Columns.Add("DataImprumut");
            cartiImprumutatedeUtilizatorDataTable.Columns.Add("DataDisponibiliate");
            cartiImprumutatedeUtilizatorDataTable.Columns.Add("Expirata");

            for (int i = 0; i < cartiImprumutate.Count; i++) {
                DataRow newRow = cartiImprumutatedeUtilizatorDataTable.NewRow();
                int index = i + 1;
                newRow[0] = index;
                newRow[1] = cartiImprumutate[i].Titlu;
                newRow[2] = cartiImprumutate[i].Autor;
                newRow[3] = cartiImprumutate[i].DataImprumut;
                newRow[4] = cartiImprumutate[i].DataDisponibilitate;
                newRow[5] = cartiImprumutate[i].CarteExpirata;
                cartiImprumutatedeUtilizatorDataTable.Rows.Add(newRow);
            }

            return cartiImprumutatedeUtilizatorDataTable;
        }


    }

}
