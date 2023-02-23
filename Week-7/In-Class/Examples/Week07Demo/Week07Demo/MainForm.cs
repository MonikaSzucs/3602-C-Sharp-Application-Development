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

        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.Select();
            textBox.SelectAll();
        }
    }
}
