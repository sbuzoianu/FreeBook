
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
            this.meniuTabControl.SuspendLayout();
            this.cartiDisponibileTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartiDisponibileDataGridView)).BeginInit();
            this.CartiImprumutateTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartiImprumutateDataGridView)).BeginInit();
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
            this.cartiDisponibileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.cartiImprumutateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartiImprumutateDataGridView.Location = new System.Drawing.Point(20, 7);
            this.cartiImprumutateDataGridView.Name = "cartiImprumutateDataGridView";
            this.cartiImprumutateDataGridView.RowTemplate.Height = 25;
            this.cartiImprumutateDataGridView.Size = new System.Drawing.Size(850, 382);
            this.cartiImprumutateDataGridView.TabIndex = 0;
            // 
            // statisticiBibliotecaTabPage
            // 
            this.statisticiBibliotecaTabPage.Location = new System.Drawing.Point(4, 24);
            this.statisticiBibliotecaTabPage.Name = "statisticiBibliotecaTabPage";
            this.statisticiBibliotecaTabPage.Size = new System.Drawing.Size(892, 460);
            this.statisticiBibliotecaTabPage.TabIndex = 2;
            this.statisticiBibliotecaTabPage.Text = "Statistici biblioteca";
            this.statisticiBibliotecaTabPage.UseVisualStyleBackColor = true;
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
    }
}