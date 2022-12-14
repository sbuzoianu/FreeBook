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

            meniuTabControl.SelectedIndexChanged += MeniuTabControl_SelectedIndexChanged;

            cartiDisponibileDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cartiDisponibileDataGridView.ReadOnly = true;
            cartiDisponibileDataGridView.MultiSelect = false;

            // Incarcare Event Handler la click pe DataGridViewCell
            cartiDisponibileDataGridView.CellContentClick += new DataGridViewCellEventHandler(CartiDisponibileDataGridView_CellContentClick);

            cartiImprumutateProgressBar.Minimum = 0;
            cartiImprumutateProgressBar.Maximum = 3;
            cartiImprumutateProgressBar.Value = 3;

        }

        private void MeniuTabControl_SelectedIndexChanged(object sender, EventArgs e) {
            switch (meniuTabControl.SelectedIndex) {

                case 0: {
                   //     cartiDisponibileDataGridView.DataSource = CartiFromDatabase.GetDataToTable();
                        break;
                    }

                case 1: {
                        //MessageBox.Show("This is " + meniuTabControl.SelectedTab.Name);
                        break;
                    }
                case 2: {
                       // MessageBox.Show("This is " + meniuTabControl.SelectedTab.Name);
                        break;
                    }
            }
        }


        private void CartiDisponibileDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            DataGridView dataGridView = (DataGridView)sender;

            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) {
                if (DatabaseHelper.NumarCartiImprumutate(Utilizator) < 3) {
                    int idCarte = Int32.Parse((string)dataGridView.Rows[e.RowIndex].Cells["id_carte"].Value);
                    DatabaseHelper.ImprumutaCarte(idCarte, Utilizator);

                    dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                } else {
                    MessageBox.Show("Aveti deja imprumutate 3 carti in ultimele 30 de zile.");
                }
            }

        }

        private void MeniuFreeBook_Load(object sender, EventArgs e) {

            // cartiDisponibileTabPage este incarcat automat deoarece el este primul
            // mai jos -> incarcare explicita a TabPage-ului
            meniuTabControl.SelectedTab = meniuTabControl.TabPages["cartiDisponibileTabPage"];
            IncarcareCartiDisponibileTab();

            emailUtilizatorLabel.Text += Utilizator.email;
        }

        private void IncarcareCartiDisponibileTab() {
            cartiImprumutateDataGridView.Rows.Clear();
            cartiImprumutateDataGridView.Columns.Clear();

            cartiDisponibileDataGridView.DataSource = CartiFromDatabase.GetDataToTable();
            cartiDisponibileDataGridView.Columns[0].Visible = false; //coloana "id_carte" nu este afisata

            DataGridViewButtonColumn buttonImprumutaCarte = new DataGridViewButtonColumn();
            cartiDisponibileDataGridView.Columns.Add(buttonImprumutaCarte);
            buttonImprumutaCarte.HeaderText = "Status Carte";
            buttonImprumutaCarte.Name = "btn";
            buttonImprumutaCarte.UseColumnTextForButtonValue = true;
        }

    }
}
