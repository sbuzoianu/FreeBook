using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FreeBook.Forms {
    public partial class MeniuFreeBook : Form {
        public UserModel Utilizator { get; set; }

        public MeniuFreeBook() {
            InitializeComponent();
        }


        private void MeniuFreeBook_Load(object sender, EventArgs e) {
            emailUtilizatorLabel.Text += Utilizator.email;
        }
    }
}
