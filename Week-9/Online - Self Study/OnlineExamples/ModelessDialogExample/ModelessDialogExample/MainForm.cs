using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModelessDialogExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void buttonOpenModeless_Click(object sender, EventArgs e)
        {
            ModelessForm modeless = new ModelessForm(); // create instance of form
            modeless.Show(); // call show method
        }

        private void buttonSingletonModeless_Click(object sender, EventArgs e)
        {
            ModelessSingletonForm singleton = ModelessSingletonForm.CreateForm(); // call static method to create instance
            singleton.Show();     // call show method
            singleton.Activate(); // makes this window the active window
        }
    }
}
