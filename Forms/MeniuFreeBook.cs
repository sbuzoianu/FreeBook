using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FreeBook.DataAccess;

namespace FreeBook.Forms {
    public partial class MeniuFreeBook : Form {
        public UserModel Utilizator { get; set; }

        public MeniuFreeBook() {
            InitializeComponent();
            cartiDisponibileDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cartiDisponibileDataGridView.ReadOnly = true;
            cartiDisponibileDataGridView.MultiSelect = false;
            cartiDisponibileDataGridView.CellContentClick += new DataGridViewCellEventHandler(CartiDisponibileDataGridView_CellContentClick);

        }

        private void CartiDisponibileDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            DataGridView dataGridView = (DataGridView)sender;

            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) {
                int nrCartiImprumutate = DatabaseHelper.NumarCartiImprumutate(Utilizator);
                if (nrCartiImprumutate < 3) {
                    int idCarte = Int32.Parse((string)dataGridView.Rows[e.RowIndex].Cells["id_carte"].Value);
                    DatabaseHelper.ImprumutaCarte(idCarte, Utilizator);

                    dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                } else {
                    MessageBox.Show("Aveti deja imprumutate 3 carti in ultimele 30 de zile.");
                }
            }

        }

        private void MeniuFreeBook_Load(object sender, EventArgs e) {

            cartiDisponibileDataGridView.DataSource = InitializareImprumuturiDatabase.GetTable();
            cartiDisponibileDataGridView.Columns[0].Visible = false;

            DataGridViewButtonColumn buttonImprumutaCarte = new DataGridViewButtonColumn();
            cartiDisponibileDataGridView.Columns.Add(buttonImprumutaCarte);
            buttonImprumutaCarte.HeaderText = "Status Carte";
            buttonImprumutaCarte.Name = "btn";
            buttonImprumutaCarte.UseColumnTextForButtonValue = true;


            emailUtilizatorLabel.Text += Utilizator.email;
        }
    }
}
