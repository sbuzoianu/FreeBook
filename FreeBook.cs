using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeBook
{
    public partial class FreeBook : Form
    {
        public FreeBook()
        {
            InitializeComponent();
            this.btn_Exit.Click += btn_Exit_Click;

        }
        // event handlers
        private void FreeBook_Load(object sender, EventArgs e)
        {
            DatabaseHelper.Initialisation();
            labelFormLoad.Text = "This text is set on startup !";
        }


        private void btn_Click_Click(object sender, EventArgs e) {
            labelFormClick.Text = btn_Click.Text;
        }

        private void btn_Clear_Click(object sender, EventArgs e) {
            labelFormClick.Text = btn_Clear.Text;
        }

        private void btn_Save_Click(object sender, EventArgs e) {
            labelFormClick.Text = btn_Save.Text;

        }

        private void btn_Exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
