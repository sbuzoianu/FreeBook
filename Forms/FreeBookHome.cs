using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FreeBook.Forms {
    public partial class FreeBookHome : Form {
        public FreeBookHome() {
            InitializeComponent();
            Load += new EventHandler(FreeBookHome_Load);

        }

        private void FreeBookHome_Load(object sender, EventArgs e) {
            DatabaseHelper.Initialisation();

        }
    }
}
