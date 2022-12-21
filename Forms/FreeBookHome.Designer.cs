
namespace FreeBook.Forms {
    partial class FreeBookHome {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreeBookHome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LogareBtn = new System.Windows.Forms.Button();
            this.InregistrareBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FreeBook.Properties.Resources.sigla_Biblioteca_Alexandria;
            this.pictureBox1.Location = new System.Drawing.Point(48, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(13, 256);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(633, 82);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // LogareBtn
            // 
            this.LogareBtn.Location = new System.Drawing.Point(48, 340);
            this.LogareBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LogareBtn.Name = "LogareBtn";
            this.LogareBtn.Size = new System.Drawing.Size(235, 30);
            this.LogareBtn.TabIndex = 2;
            this.LogareBtn.Text = "LOGIN";
            this.LogareBtn.UseVisualStyleBackColor = true;
            this.LogareBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // InregistrareBtn
            // 
            this.InregistrareBtn.Location = new System.Drawing.Point(377, 340);
            this.InregistrareBtn.Margin = new System.Windows.Forms.Padding(2);
            this.InregistrareBtn.Name = "InregistrareBtn";
            this.InregistrareBtn.Size = new System.Drawing.Size(235, 30);
            this.InregistrareBtn.TabIndex = 3;
            this.InregistrareBtn.Text = "INREGISTRARE";
            this.InregistrareBtn.UseVisualStyleBackColor = true;
            this.InregistrareBtn.Click += new System.EventHandler(this.InregistrareBtn_Click);
            // 
            // FreeBookHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 377);
            this.Controls.Add(this.InregistrareBtn);
            this.Controls.Add(this.LogareBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FreeBookHome";
            this.Text = "FreeBookHome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button LogareBtn;
        private System.Windows.Forms.Button InregistrareBtn;
    }
}