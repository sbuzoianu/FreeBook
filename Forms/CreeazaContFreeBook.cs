using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FreeBook.Forms {
    public partial class CreeazaContFreeBook : Form {
        public CreeazaContFreeBook() {
            InitializeComponent();
            parolaTextBox.PasswordChar = '*';
            confirmareParolaTextBox.PasswordChar = '*';
        }

        private void inregistrareContBtn_Click(object sender, EventArgs e) {
            if (parolaTextBox.Text != string.Empty && 
                confirmareParolaTextBox.Text != string.Empty &&
                numeTextBox.Text != string.Empty &&
                prenumeTextBox.Text != string.Empty &&
                emailTextBox.Text != string.Empty) {

                if (parolaTextBox.Text == confirmareParolaTextBox.Text) {
                    UserModel utilizator = new UserModel {
                        email = emailTextBox.Text,
                        nume = numeTextBox.Text,
                        prenume = prenumeTextBox.Text,
                        parola = parolaTextBox.Text
                    };
                        

                } else {
                    MessageBox.Show("Parola nu a fost confirmata corect!");
                }
            } else {
                MessageBox.Show("Introduceti valori pentru toate campurile definite!");
            }
        }
    }
}
