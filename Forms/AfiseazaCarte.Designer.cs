
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
            this.continutWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.indexCarteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.continutWebView)).BeginInit();
            this.SuspendLayout();
            // 
            // afiseazaTitluLabel
            // 
            this.afiseazaTitluLabel.AutoSize = true;
            this.afiseazaTitluLabel.Location = new System.Drawing.Point(12, 9);
            this.afiseazaTitluLabel.Name = "afiseazaTitluLabel";
            this.afiseazaTitluLabel.Size = new System.Drawing.Size(38, 15);
            this.afiseazaTitluLabel.TabIndex = 0;
            this.afiseazaTitluLabel.Text = "label1";
            // 
            // afiseazaAutorLabel
            // 
            this.afiseazaAutorLabel.AutoSize = true;
            this.afiseazaAutorLabel.Location = new System.Drawing.Point(12, 38);
            this.afiseazaAutorLabel.Name = "afiseazaAutorLabel";
            this.afiseazaAutorLabel.Size = new System.Drawing.Size(38, 15);
            this.afiseazaAutorLabel.TabIndex = 1;
            this.afiseazaAutorLabel.Text = "label1";
            // 
            // continutWebView
            // 
            this.continutWebView.AllowExternalDrop = true;
            this.continutWebView.CreationProperties = null;
            this.continutWebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.continutWebView.Location = new System.Drawing.Point(69, 0);
            this.continutWebView.Name = "continutWebView";
            this.continutWebView.Size = new System.Drawing.Size(733, 449);
            this.continutWebView.TabIndex = 2;
            this.continutWebView.ZoomFactor = 1D;
            // 
            // indexCarteLabel
            // 
            this.indexCarteLabel.AutoSize = true;
            this.indexCarteLabel.Location = new System.Drawing.Point(12, 66);
            this.indexCarteLabel.Name = "indexCarteLabel";
            this.indexCarteLabel.Size = new System.Drawing.Size(38, 15);
            this.indexCarteLabel.TabIndex = 3;
            this.indexCarteLabel.Text = "label1";
            this.indexCarteLabel.Visible = false;
            // 
            // AfiseazaCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.indexCarteLabel);
            this.Controls.Add(this.continutWebView);
            this.Controls.Add(this.afiseazaAutorLabel);
            this.Controls.Add(this.afiseazaTitluLabel);
            this.Name = "AfiseazaCarte";
            this.Text = "AfiseazaCarte";
            this.Load += new System.EventHandler(this.AfiseazaCarte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.continutWebView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label afiseazaTitluLabel;
        public System.Windows.Forms.Label afiseazaAutorLabel;
        public Microsoft.Web.WebView2.WinForms.WebView2 continutWebView;
        public System.Windows.Forms.Label indexCarteLabel;
    }
}