using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FreeBook.Forms {
    public partial class LogareFreeBook : Form {
        public LogareFreeBook() {
            InitializeComponent();
            // vizibile doar in run-time
            emailLabel.Text = "Email";
            passwordLabel.Text = "Parola";
            parolaTextBox.PasswordChar = '*';
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void logareButton_Click(object sender, EventArgs e) {
            //TODO: add logic to check curent credentials 
            UserModel utilizator = DatabaseHelper.IsRegistered(emailTextBox.Text);

            if(utilizator.parola == parolaTextBox.Text) {
                this.Close();
                this.Visible = false;
                var page = new MeniuFreeBook() {
                    Utilizator = utilizator
                };
                page.ShowDialog(this);
            } 
            else {
                MessageBox.Show("Eorare autentificare");
            }
        }
    }
}
