using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FreeBook.DataAccess;
using FreeBook.Models;
// Visual Studio Shortcut
// Ctrl + M, P to expand
// Ctrl + M, O to collapse.

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

            cartiImprumutateDataGridView.CellContentClick += new DataGridViewCellEventHandler(CartiImprumutateDataGridView_CellContentClick);
            cartiImprumutateDataGridView.Rows.Clear();
            cartiImprumutateDataGridView.Columns.Clear();

            SetCartiImprumutateProgressBar();

        }

        private void CartiImprumutateDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            this.Hide();
            AfiseazaCarte carte = new AfiseazaCarte();
            carte.afiseazaTitluLabel.Text = this.cartiImprumutateDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            carte.afiseazaAutorLabel.Text = this.cartiImprumutateDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            carte.indexCarteLabel.Text = this.cartiImprumutateDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            carte.ShowDialog();
            this.Show();

        }

        private void SetCartiImprumutateProgressBar() {
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
                        cartiImprumutateDataGridView.DataSource = DataTableSourceFromDatabase.GetAllAssignedBooksIntoDataTable(Utilizator);
                        cartiImprumutateDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        SetCartiImprumutateProgressBar();
                        for (int i = 0; i < cartiImprumutateDataGridView.Rows.Count - 1; i++) {
                            if (bool.Parse((string)cartiImprumutateDataGridView.Rows[i].Cells[5].Value)) {
                                cartiImprumutateDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                                cartiImprumutateProgressBar.Value--;
                            } else {
                                cartiImprumutateDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                cartiImprumutateProgressBar.Value--;
                            }
                        }
                        cartiDisponibileLabel.Text = cartiImprumutateProgressBar.Value.ToString() + "/3";
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
                    int operatieReusita = DatabaseHelper.ImprumutaCarte(idCarte, Utilizator);
                    if (operatieReusita != 0)
                        MessageBox.Show("Utilizatorul" + Utilizator.nume + " a imprumutat deja aceasta carte!");

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
            IncarcareStatisticiBibliotecaTab_NumarUtilizatoriChart();
            IncarcareStatisticiBibliotecaTab_CartiChartPie();

            emailUtilizatorLabel.Text += Utilizator.email;
        }

        private void IncarcareStatisticiBibliotecaTab_NumarUtilizatoriChart() {
            numarUtilizatoriLunaChart.Series.Clear();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy";
            dateTimePicker.Value = DateTime.Now;
            Series serie = new Series() {
                Name = "Luna"
            };

            DateTime an = dateTimePicker.Value.AddDays(1 - dateTimePicker.Value.DayOfYear);
            var imprumuturiAn = DatabaseHelper.GetImprumuturiCartiPeAn(an, an.AddYears(1)).Select(x => x.DataImprumut).OrderBy(x => x).Select(x => x.ToString("MMM")).ToList();
            var stats = imprumuturiAn.GroupBy(x => x).ToList();

            DateTime temp = DateTime.Now.AddDays(1 - DateTime.Now.DayOfYear);
            for (int i = 0; i < 11; i++) {
                string data = temp.ToString("MMM");
                serie.Points.AddXY(data, 0);
                temp = temp.AddMonths(1);
            }

            foreach (var item in stats) {
                serie.Points.AddXY(item.First(), item.Count());
            }

            numarUtilizatoriLunaChart.Series.Add(serie);
            numarUtilizatoriLunaChart.ChartAreas[0].AxisX.Interval = 1;
            numarUtilizatoriLunaChart.Series[0].IsValueShownAsLabel = true;
            numarUtilizatoriLunaChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            numarUtilizatoriLunaChart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            numarUtilizatoriLunaChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            numarUtilizatoriLunaChart.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
        }

        private void IncarcareStatisticiBibliotecaTab_CartiChartPie() {
            List<string> carti = DatabaseHelper.GetCartiCitite().OrderBy(x => x).ToList();
            var celeMaiCitieCarti = carti.GroupBy(x => x).OrderByDescending(x => x.Count()).Take(4).ToList();
            cartiPopulareChart.Series.Clear();
            Series series = new Series("Carti populare") {
                ChartType = SeriesChartType.Pie
            };

            foreach (var item in celeMaiCitieCarti) {
                series.Points.AddXY(item.First(), item.Count());
            }

            cartiPopulareChart.Series.Add(series);
            cartiPopulareChart.Series[0].IsValueShownAsLabel = true;

        }

        private void IncarcareCartiDisponibileTab() {
            cartiImprumutateDataGridView.Rows.Clear();
            cartiImprumutateDataGridView.Columns.Clear();

            cartiDisponibileDataGridView.DataSource = DataTableSourceFromDatabase.GetAllAvailableBooksIntoDataTable();
            cartiDisponibileDataGridView.Columns[0].Visible = false; //coloana "id_carte" nu este afisata

            DataGridViewButtonColumn buttonImprumutaCarte = new DataGridViewButtonColumn();
            cartiDisponibileDataGridView.Columns.Add(buttonImprumutaCarte);
            buttonImprumutaCarte.HeaderText = "Status Carte";
            buttonImprumutaCarte.Name = "btn";
            buttonImprumutaCarte.UseColumnTextForButtonValue = true;
        }

        private void cartiPopulareChart_CustomizeLegend(object sender, CustomizeLegendEventArgs e) {
            cartiPopulareChart.Legends[0].Docking = Docking.Bottom;
            cartiPopulareChart.Legends[0].BorderColor = Color.Black;
            cartiPopulareChart.Legends[0].Alignment = StringAlignment.Center;
            cartiPopulareChart.Legends[0].Title = "Carti Imprumutate";
        }
    }
}
