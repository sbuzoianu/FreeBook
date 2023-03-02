
namespace FreeBook.Forms {
    partial class AfiseazaCarte {
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
            this.afiseazaTitluLabel = new System.Windows.Forms.Label();
            this.afiseazaAutorLabel = new System.Windows.Forms.Label();
            this.indexCarteLabel = new System.Windows.Forms.Label();
            this.afiseazaCarteWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // afiseazaTitluLabel
            // 
            this.afiseazaTitluLabel.AutoSize = true;
            this.afiseazaTitluLabel.Location = new System.Drawing.Point(10, 8);
            this.afiseazaTitluLabel.Name = "afiseazaTitluLabel";
            this.afiseazaTitluLabel.Size = new System.Drawing.Size(35, 13);
            this.afiseazaTitluLabel.TabIndex = 0;
            this.afiseazaTitluLabel.Text = "label1";
            // 
            // afiseazaAutorLabel
            // 
            this.afiseazaAutorLabel.AutoSize = true;
            this.afiseazaAutorLabel.Location = new System.Drawing.Point(10, 33);
            this.afiseazaAutorLabel.Name = "afiseazaAutorLabel";
            this.afiseazaAutorLabel.Size = new System.Drawing.Size(35, 13);
            this.afiseazaAutorLabel.TabIndex = 1;
            this.afiseazaAutorLabel.Text = "label1";
            // 
            // indexCarteLabel
            // 
            this.indexCarteLabel.AutoSize = true;
            this.indexCarteLabel.Location = new System.Drawing.Point(10, 57);
            this.indexCarteLabel.Name = "indexCarteLabel";
            this.indexCarteLabel.Size = new System.Drawing.Size(35, 13);
            this.indexCarteLabel.TabIndex = 3;
            this.indexCarteLabel.Text = "label1";
            this.indexCarteLabel.Visible = false;
            // 
            // afiseazaCarteWebBrowser
            // 
            this.afiseazaCarteWebBrowser.Location = new System.Drawing.Point(72, 13);
            this.afiseazaCarteWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.afiseazaCarteWebBrowser.Name = "afiseazaCarteWebBrowser";
            this.afiseazaCarteWebBrowser.Size = new System.Drawing.Size(593, 365);
            this.afiseazaCarteWebBrowser.TabIndex = 4;
            // 
            // AfiseazaCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.afiseazaCarteWebBrowser);
            this.Controls.Add(this.indexCarteLabel);
            this.Controls.Add(this.afiseazaAutorLabel);
            this.Controls.Add(this.afiseazaTitluLabel);
            this.Name = "AfiseazaCarte";
            this.Text = "AfiseazaCarte";
            this.Load += new System.EventHandler(this.AfiseazaCarte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label afiseazaTitluLabel;
        public System.Windows.Forms.Label afiseazaAutorLabel;
        public System.Windows.Forms.Label indexCarteLabel;
        private System.Windows.Forms.WebBrowser afiseazaCarteWebBrowser;
    }
}