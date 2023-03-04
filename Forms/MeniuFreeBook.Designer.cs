
namespace FreeBook.Forms {
    partial class MeniuFreeBook {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.emailUtilizatorLabel = new System.Windows.Forms.Label();
            this.meniuTabControl = new System.Windows.Forms.TabControl();
            this.cartiDisponibileTabPage = new System.Windows.Forms.TabPage();
            this.cartiDisponibileDataGridView = new System.Windows.Forms.DataGridView();
            this.CartiImprumutateTabPage = new System.Windows.Forms.TabPage();
            this.cartiDisponibileLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cartiImprumutateProgressBar = new System.Windows.Forms.ProgressBar();
            this.cartiImprumutateDataGridView = new System.Windows.Forms.DataGridView();
            this.statisticiBibliotecaTabPage = new System.Windows.Forms.TabPage();
            this.statisticiTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numarUtilizatoriLunaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.anImprumutLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cartiPopulareChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meniuTabControl.SuspendLayout();
            this.cartiDisponibileTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartiDisponibileDataGridView)).BeginInit();
            this.CartiImprumutateTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartiImprumutateDataGridView)).BeginInit();
            this.statisticiBibliotecaTabPage.SuspendLayout();
            this.statisticiTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numarUtilizatoriLunaChart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartiPopulareChart)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailUtilizatorLabel
            // 
            this.emailUtilizatorLabel.AutoSize = true;
            this.emailUtilizatorLabel.Location = new System.Drawing.Point(204, 27);
            this.emailUtilizatorLabel.Name = "emailUtilizatorLabel";
            this.emailUtilizatorLabel.Size = new System.Drawing.Size(76, 13);
            this.emailUtilizatorLabel.TabIndex = 0;
            this.emailUtilizatorLabel.Text = "Email utilizator:";
            // 
            // meniuTabControl
            // 
            this.meniuTabControl.Controls.Add(this.cartiDisponibileTabPage);
            this.meniuTabControl.Controls.Add(this.CartiImprumutateTabPage);
            this.meniuTabControl.Controls.Add(this.statisticiBibliotecaTabPage);
            this.meniuTabControl.Location = new System.Drawing.Point(34, 55);
            this.meniuTabControl.Name = "meniuTabControl";
            this.meniuTabControl.SelectedIndex = 0;
            this.meniuTabControl.Size = new System.Drawing.Size(771, 423);
            this.meniuTabControl.TabIndex = 1;
            // 
            // cartiDisponibileTabPage
            // 
            this.cartiDisponibileTabPage.Controls.Add(this.cartiDisponibileDataGridView);
            this.cartiDisponibileTabPage.Location = new System.Drawing.Point(4, 22);
            this.cartiDisponibileTabPage.Name = "cartiDisponibileTabPage";
            this.cartiDisponibileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cartiDisponibileTabPage.Size = new System.Drawing.Size(763, 397);
            this.cartiDisponibileTabPage.TabIndex = 0;
            this.cartiDisponibileTabPage.Text = "Carti disponibile";
            this.cartiDisponibileTabPage.UseVisualStyleBackColor = true;
            // 
            // cartiDisponibileDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartiDisponibileDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cartiDisponibileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartiDisponibileDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.cartiDisponibileDataGridView.Location = new System.Drawing.Point(-3, -1);
            this.cartiDisponibileDataGridView.Name = "cartiDisponibileDataGridView";
            this.cartiDisponibileDataGridView.RowTemplate.Height = 25;
            this.cartiDisponibileDataGridView.Size = new System.Drawing.Size(768, 400);
            this.cartiDisponibileDataGridView.TabIndex = 0;
            // 
            // CartiImprumutateTabPage
            // 
            this.CartiImprumutateTabPage.Controls.Add(this.cartiDisponibileLabel);
            this.CartiImprumutateTabPage.Controls.Add(this.label1);
            this.CartiImprumutateTabPage.Controls.Add(this.cartiImprumutateProgressBar);
            this.CartiImprumutateTabPage.Controls.Add(this.cartiImprumutateDataGridView);
            this.CartiImprumutateTabPage.Location = new System.Drawing.Point(4, 22);
            this.CartiImprumutateTabPage.Name = "CartiImprumutateTabPage";
            this.CartiImprumutateTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CartiImprumutateTabPage.Size = new System.Drawing.Size(763, 397);
            this.CartiImprumutateTabPage.TabIndex = 1;
            this.CartiImprumutateTabPage.Text = "Carti Imprumutate";
            this.CartiImprumutateTabPage.UseVisualStyleBackColor = true;
            // 
            // cartiDisponibileLabel
            // 
            this.cartiDisponibileLabel.AutoSize = true;
            this.cartiDisponibileLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cartiDisponibileLabel.Location = new System.Drawing.Point(232, 355);
            this.cartiDisponibileLabel.Name = "cartiDisponibileLabel";
            this.cartiDisponibileLabel.Size = new System.Drawing.Size(39, 25);
            this.cartiDisponibileLabel.TabIndex = 3;
            this.cartiDisponibileLabel.Text = "3/3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.Location = new System.Drawing.Point(5, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Disponibilitate imprumuturi : ";
            // 
            // cartiImprumutateProgressBar
            // 
            this.cartiImprumutateProgressBar.Location = new System.Drawing.Point(369, 355);
            this.cartiImprumutateProgressBar.Name = "cartiImprumutateProgressBar";
            this.cartiImprumutateProgressBar.Size = new System.Drawing.Size(376, 29);
            this.cartiImprumutateProgressBar.TabIndex = 1;
            // 
            // cartiImprumutateDataGridView
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartiImprumutateDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.cartiImprumutateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartiImprumutateDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.cartiImprumutateDataGridView.Location = new System.Drawing.Point(17, 6);
            this.cartiImprumutateDataGridView.Name = "cartiImprumutateDataGridView";
            this.cartiImprumutateDataGridView.RowTemplate.Height = 25;
            this.cartiImprumutateDataGridView.Size = new System.Drawing.Size(729, 331);
            this.cartiImprumutateDataGridView.TabIndex = 0;
            // 
            // statisticiBibliotecaTabPage
            // 
            this.statisticiBibliotecaTabPage.Controls.Add(this.statisticiTabControl);
            this.statisticiBibliotecaTabPage.Location = new System.Drawing.Point(4, 22);
            this.statisticiBibliotecaTabPage.Name = "statisticiBibliotecaTabPage";
            this.statisticiBibliotecaTabPage.Size = new System.Drawing.Size(763, 397);
            this.statisticiBibliotecaTabPage.TabIndex = 2;
            this.statisticiBibliotecaTabPage.Text = "Statistici biblioteca";
            this.statisticiBibliotecaTabPage.UseVisualStyleBackColor = true;
            // 
            // statisticiTabControl
            // 
            this.statisticiTabControl.Controls.Add(this.tabPage1);
            this.statisticiTabControl.Controls.Add(this.tabPage2);
            this.statisticiTabControl.Location = new System.Drawing.Point(3, 3);
            this.statisticiTabControl.Name = "statisticiTabControl";
            this.statisticiTabControl.SelectedIndex = 0;
            this.statisticiTabControl.Size = new System.Drawing.Size(762, 393);
            this.statisticiTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numarUtilizatoriLunaChart);
            this.tabPage1.Controls.Add(this.dateTimePicker);
            this.tabPage1.Controls.Add(this.anImprumutLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Numar utilizatori";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numarUtilizatoriLunaChart
            // 
            chartArea1.Name = "ChartArea1";
            this.numarUtilizatoriLunaChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.numarUtilizatoriLunaChart.Legends.Add(legend1);
            this.numarUtilizatoriLunaChart.Location = new System.Drawing.Point(11, 47);
            this.numarUtilizatoriLunaChart.Name = "numarUtilizatoriLunaChart";
            this.numarUtilizatoriLunaChart.Size = new System.Drawing.Size(737, 314);
            this.numarUtilizatoriLunaChart.TabIndex = 2;
            this.numarUtilizatoriLunaChart.Text = "chart1";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(121, 19);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(78, 25);
            this.dateTimePicker.TabIndex = 1;
            // 
            // anImprumutLabel
            // 
            this.anImprumutLabel.AutoSize = true;
            this.anImprumutLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.anImprumutLabel.Location = new System.Drawing.Point(6, 18);
            this.anImprumutLabel.Name = "anImprumutLabel";
            this.anImprumutLabel.Size = new System.Drawing.Size(127, 25);
            this.anImprumutLabel.TabIndex = 0;
            this.anImprumutLabel.Text = "An Imprumut:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cartiPopulareChart);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Carti populare";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cartiPopulareChart
            // 
            chartArea2.Name = "ChartArea1";
            this.cartiPopulareChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cartiPopulareChart.Legends.Add(legend2);
            this.cartiPopulareChart.Location = new System.Drawing.Point(7, 78);
            this.cartiPopulareChart.Name = "cartiPopulareChart";
            this.cartiPopulareChart.Size = new System.Drawing.Size(730, 283);
            this.cartiPopulareChart.TabIndex = 1;
            this.cartiPopulareChart.Text = "chart1";
            this.cartiPopulareChart.CustomizeLegend += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CustomizeLegendEventArgs>(this.cartiPopulareChart_CustomizeLegend);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Carti populare";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(825, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // MeniuFreeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 488);
            this.Controls.Add(this.meniuTabControl);
            this.Controls.Add(this.emailUtilizatorLabel);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MeniuFreeBook";
            this.Text = "MeniuFreeBook";
            this.Load += new System.EventHandler(this.MeniuFreeBook_Load);
            this.meniuTabControl.ResumeLayout(false);
            this.cartiDisponibileTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartiDisponibileDataGridView)).EndInit();
            this.CartiImprumutateTabPage.ResumeLayout(false);
            this.CartiImprumutateTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartiImprumutateDataGridView)).EndInit();
            this.statisticiBibliotecaTabPage.ResumeLayout(false);
            this.statisticiTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numarUtilizatoriLunaChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartiPopulareChart)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailUtilizatorLabel;
        private System.Windows.Forms.TabControl meniuTabControl;
        private System.Windows.Forms.TabPage cartiDisponibileTabPage;
        private System.Windows.Forms.TabPage CartiImprumutateTabPage;
        private System.Windows.Forms.TabPage statisticiBibliotecaTabPage;
        private System.Windows.Forms.DataGridView cartiDisponibileDataGridView;
        private System.Windows.Forms.DataGridView cartiImprumutateDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar cartiImprumutateProgressBar;
        private System.Windows.Forms.Label cartiDisponibileLabel;
        private System.Windows.Forms.TabControl statisticiTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
        public System.Windows.Forms.Label anImprumutLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart numarUtilizatoriLunaChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart cartiPopulareChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
    }
}