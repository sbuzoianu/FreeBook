
namespace FreeBook.Forms {
    partial class LogareFreeBook {
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
            this.logareGroupBox = new System.Windows.Forms.GroupBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.parolaTextBox = new System.Windows.Forms.TextBox();
            this.logareButton = new System.Windows.Forms.Button();
            this.logareGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logareGroupBox
            // 
            this.logareGroupBox.Controls.Add(this.parolaTextBox);
            this.logareGroupBox.Controls.Add(this.emailTextBox);
            this.logareGroupBox.Controls.Add(this.passwordLabel);
            this.logareGroupBox.Controls.Add(this.emailLabel);
            this.logareGroupBox.Location = new System.Drawing.Point(13, 13);
            this.logareGroupBox.Name = "logareGroupBox";
            this.logareGroupBox.Size = new System.Drawing.Size(775, 310);
            this.logareGroupBox.TabIndex = 0;
            this.logareGroupBox.TabStop = false;
            this.logareGroupBox.Text = "Date utilizator";
            this.logareGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(45, 97);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(54, 25);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(45, 175);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(60, 25);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Parola";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(158, 97);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(394, 31);
            this.emailTextBox.TabIndex = 2;
            // 
            // parolaTextBox
            // 
            this.parolaTextBox.Location = new System.Drawing.Point(158, 175);
            this.parolaTextBox.Name = "parolaTextBox";
            this.parolaTextBox.Size = new System.Drawing.Size(394, 31);
            this.parolaTextBox.TabIndex = 3;
            // 
            // logareButton
            // 
            this.logareButton.Location = new System.Drawing.Point(356, 355);
            this.logareButton.Name = "logareButton";
            this.logareButton.Size = new System.Drawing.Size(112, 34);
            this.logareButton.TabIndex = 1;
            this.logareButton.Text = "Logare";
            this.logareButton.UseVisualStyleBackColor = true;
            this.logareButton.Click += new System.EventHandler(this.logareButton_Click);
            // 
            // LogareFreeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 426);
            this.Controls.Add(this.logareButton);
            this.Controls.Add(this.logareGroupBox);
            this.Name = "LogareFreeBook";
            this.Text = "LogareFreeBook";
            this.logareGroupBox.ResumeLayout(false);
            this.logareGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox logareGroupBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox parolaTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button logareButton;
    }
}