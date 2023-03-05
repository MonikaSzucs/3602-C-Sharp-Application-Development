using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPadDemo
{
    public partial class KeyPadForm : Form
    {
        public KeyPadForm()
        {
            InitializeComponent();
        }

        private void Keypad_Load(object sender, EventArgs e)
        {
            labelDisplay.Text = "0";
        }

        private void buttonKey0_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string value = button.Text;

            switch (value)
            {
                case "C":
                    labelDisplay.Text = "0";
                    break;

                case ".":
                    if (!labelDisplay.Text.Contains("."))
                    {
                        labelDisplay.Text += value;
                    }
                    break;

                default:
                    if (labelDisplay.Text == "0")
                    {
                        labelDisplay.Text = "";
                    }

                    labelDisplay.Text += value;
                    break;
            }
        }
    }
}
