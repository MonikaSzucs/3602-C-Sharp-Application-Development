using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalDialogDemo
{
    public partial class MainForm : Form
    {
        private string userName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelResult.Text = string.Empty;
            this.userName = "Cosmo Kramer";
        }

        private void buttonShowEditDialog_Click(object sender, EventArgs e)
        {
            labelResult.Text = string.Empty;

            EditDialog dlg = new EditDialog();        // create instance of Dialog
            dlg.UserName = userName;                  // assign value to Dialog Property 
            dlg.ShowDialog();                         //  (just like any data class)

            if (dlg.DialogResult == DialogResult.OK)  // test that OK button was clicked
            {
                userName = dlg.UserName;              // read value from Dialog Property
                labelResult.Text = userName;
            }

            dlg.Dispose();                            // always call dispose 
        }
    }
}
