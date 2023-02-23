using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week07Demo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Welcome {textBoxFirstName.Text}!");
        }

        private void textBoxFirstName_MouseEnter(object sender, EventArgs e)
        {
            TextBox triggeredTextBox = (TextBox)sender;
            triggeredTextBox.BackColor = Color.Yellow;
            if(!buttonOK.Visible)
            {
                buttonOK.Visible = true;
            } else
            {
                buttonOK.Visible = false;
            }   
        }

        private void textBoxFirstName_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
