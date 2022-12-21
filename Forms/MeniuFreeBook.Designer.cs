
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
            this.CartiImprumutateTabPage = new System.Windows.Forms.TabPage();
            this.statisticiBibliotecaTabPage = new System.Windows.Forms.TabPage();
            this.meniuTabControl.SuspendLayout();
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
            this.cartiDisponibileTabPage.Location = new System.Drawing.Point(4, 24);
            this.cartiDisponibileTabPage.Name = "cartiDisponibileTabPage";
            this.cartiDisponibileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cartiDisponibileTabPage.Size = new System.Drawing.Size(892, 460);
            this.cartiDisponibileTabPage.TabIndex = 0;
            this.cartiDisponibileTabPage.Text = "Carti disponibile";
            this.cartiDisponibileTabPage.UseVisualStyleBackColor = true;
            // 
            // CartiImprumutateTabPage
            // 
            this.CartiImprumutateTabPage.Location = new System.Drawing.Point(4, 24);
            this.CartiImprumutateTabPage.Name = "CartiImprumutateTabPage";
            this.CartiImprumutateTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CartiImprumutateTabPage.Size = new System.Drawing.Size(892, 460);
            this.CartiImprumutateTabPage.TabIndex = 1;
            this.CartiImprumutateTabPage.Text = "Carti Imprumutate";
            this.CartiImprumutateTabPage.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailUtilizatorLabel;
        private System.Windows.Forms.TabControl meniuTabControl;
        private System.Windows.Forms.TabPage cartiDisponibileTabPage;
        private System.Windows.Forms.TabPage CartiImprumutateTabPage;
        private System.Windows.Forms.TabPage statisticiBibliotecaTabPage;
    }
}