using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeBook.Forms {
    public partial class AfiseazaCarte : Form {
        public Task App { get; set; }
        public AfiseazaCarte() {
            InitializeComponent();

        }


        private void AfiseazaCarte_Load(object sender, EventArgs e) {
            // TO-DO: check string format like an URI.
            afiseazaCarteWebBrowser.Url = new Uri(SqlDataAccess.GetCartiPDFPathStrings() + indexCarteLabel.Text + ".pdf");
        }
    }
}
