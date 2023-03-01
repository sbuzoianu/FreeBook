
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.anImprumutLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.meniuTabControl.SuspendLayout();
            this.cartiDisponibileTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartiDisponibileDataGridView)).BeginInit();
            this.CartiImprumutateTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartiImprumutateDataGridView)).BeginInit();
            this.statisticiBibliotecaTabPage.SuspendLayout();
            this.statisticiTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailUtilizatorLabel
            // 
            this.emailUtilizatorLabel.AutoSize = true;
            this.emailUtilizatorLabel.Location = new System.Drawing.Point(238, 31);
            this.emailUtilizatorLabel.Name = "emailUtilizatorLabel";
            this.emailUtilizatorLabel.Size = new System.Drawing.Size(88, 15);
            this.emailUtilizatorLabel.TabIndex = 0;
            this.emailUtilizatorLabel.Text = "Email utilizator:";
            // 
            // meniuTabControl
            // 
            this.meniuTabControl.Controls.Add(this.cartiDisponibileTabPage);
            this.meniuTabControl.Controls.Add(this.CartiImprumutateTabPage);
            this.meniuTabControl.Controls.Add(this.statisticiBibliotecaTabPage);
            this.meniuTabControl.Location = new System.Drawing.Point(40, 63);
            this.meniuTabControl.Name = "meniuTabControl";
            this.meniuTabControl.SelectedIndex = 0;
            this.meniuTabControl.Size = new System.Drawing.Size(900, 488);
            this.meniuTabControl.TabIndex = 1;
            // 
            // cartiDisponibileTabPage
            // 
            this.cartiDisponibileTabPage.Controls.Add(this.cartiDisponibileDataGridView);
            this.cartiDisponibileTabPage.Location = new System.Drawing.Point(4, 24);
            this.cartiDisponibileTabPage.Name = "cartiDisponibileTabPage";
            this.cartiDisponibileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cartiDisponibileTabPage.Size = new System.Drawing.Size(892, 460);
            this.cartiDisponibileTabPage.TabIndex = 0;
            this.cartiDisponibileTabPage.Text = "Carti disponibile";
            this.cartiDisponibileTabPage.UseVisualStyleBackColor = true;
            // 
            // cartiDisponibileDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartiDisponibileDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cartiDisponibileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartiDisponibileDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.cartiDisponibileDataGridView.Location = new System.Drawing.Point(-4, -1);
            this.cartiDisponibileDataGridView.Name = "cartiDisponibileDataGridView";
            this.cartiDisponibileDataGridView.RowTemplate.Height = 25;
            this.cartiDisponibileDataGridView.Size = new System.Drawing.Size(896, 461);
            this.cartiDisponibileDataGridView.TabIndex = 0;
            // 
            // CartiImprumutateTabPage
            // 
            this.CartiImprumutateTabPage.Controls.Add(this.cartiDisponibileLabel);
            this.CartiImprumutateTabPage.Controls.Add(this.label1);
            this.CartiImprumutateTabPage.Controls.Add(this.cartiImprumutateProgressBar);
            this.CartiImprumutateTabPage.Controls.Add(this.cartiImprumutateDataGridView);
            this.CartiImprumutateTabPage.Location = new System.Drawing.Point(4, 24);
            this.CartiImprumutateTabPage.Name = "CartiImprumutateTabPage";
            this.CartiImprumutateTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CartiImprumutateTabPage.Size = new System.Drawing.Size(892, 460);
            this.CartiImprumutateTabPage.TabIndex = 1;
            this.CartiImprumutateTabPage.Text = "Carti Imprumutate";
            this.CartiImprumutateTabPage.UseVisualStyleBackColor = true;
            // 
            // cartiDisponibileLabel
            // 
            this.cartiDisponibileLabel.AutoSize = true;
            this.cartiDisponibileLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cartiDisponibileLabel.Location = new System.Drawing.Point(271, 410);
            this.cartiDisponibileLabel.Name = "cartiDisponibileLabel";
            this.cartiDisponibileLabel.Size = new System.Drawing.Size(39, 25);
            this.cartiDisponibileLabel.TabIndex = 3;
            this.cartiDisponibileLabel.Text = "3/3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Disponibilitate imprumuturi : ";
            // 
            // cartiImprumutateProgressBar
            // 
            this.cartiImprumutateProgressBar.Location = new System.Drawing.Point(431, 410);
            this.cartiImprumutateProgressBar.Name = "cartiImprumutateProgressBar";
            this.cartiImprumutateProgressBar.Size = new System.Drawing.Size(439, 34);
            this.cartiImprumutateProgressBar.TabIndex = 1;
            // 
            // cartiImprumutateDataGridView
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartiImprumutateDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.cartiImprumutateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartiImprumutateDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.cartiImprumutateDataGridView.Location = new System.Drawing.Point(20, 7);
            this.cartiImprumutateDataGridView.Name = "cartiImprumutateDataGridView";
            this.cartiImprumutateDataGridView.RowTemplate.Height = 25;
            this.cartiImprumutateDataGridView.Size = new System.Drawing.Size(850, 382);
            this.cartiImprumutateDataGridView.TabIndex = 0;
            // 
            // statisticiBibliotecaTabPage
            // 
            this.statisticiBibliotecaTabPage.Controls.Add(this.statisticiTabControl);
            this.statisticiBibliotecaTabPage.Location = new System.Drawing.Point(4, 24);
            this.statisticiBibliotecaTabPage.Name = "statisticiBibliotecaTabPage";
            this.statisticiBibliotecaTabPage.Size = new System.Drawing.Size(892, 460);
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
            this.statisticiTabControl.Size = new System.Drawing.Size(889, 454);
            this.statisticiTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker);
            this.tabPage1.Controls.Add(this.anImprumutLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(881, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Numar utilizatori";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(881, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Carti populare";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // anImprumutLabel
            // 
            this.anImprumutLabel.AutoSize = true;
            this.anImprumutLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.anImprumutLabel.Location = new System.Drawing.Point(7, 21);
            this.anImprumutLabel.Name = "anImprumutLabel";
            this.anImprumutLabel.Size = new System.Drawing.Size(127, 25);
            this.anImprumutLabel.TabIndex = 0;
            this.anImprumutLabel.Text = "An Imprumut:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Location = new System.Drawing.Point(141, 22);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 33);
            this.dateTimePicker.TabIndex = 1;
            // 
            // MeniuFreeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 563);
            this.Controls.Add(this.meniuTabControl);
            this.Controls.Add(this.emailUtilizatorLabel);
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
    }
}