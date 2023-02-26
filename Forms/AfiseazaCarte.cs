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
            InitializeWebView();

        }

        private void InitializeWebView() {
            App = continutWebView.EnsureCoreWebView2Async(null);
        }

        private async  void AfiseazaCarte_Load(object sender, EventArgs e) {
            // WebBrowser control not available since VS 2019. Instead, use WebView2 nuget - not recommended 
            await App;
            continutWebView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            if (continutWebView != null && continutWebView.CoreWebView2 != null) {
                // TO-DO: obtain index value fault
                continutWebView.CoreWebView2.Navigate(SqlDataAccess.GetCartiPDFPathStrings() + indexCarteLabel.Text + ".pdf");
            }
        }
    }
}
