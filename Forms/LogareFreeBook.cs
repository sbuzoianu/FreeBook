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
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void logareButton_Click(object sender, EventArgs e) {
            //TODO: add logic to check curent credentials 
        }
    }
}
