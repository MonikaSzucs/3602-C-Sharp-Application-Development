using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextBoxExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // clear design time value
            labelGreeting.Text = string.Empty;
        }

        private void buttonCreateGreeting_Click(object sender, EventArgs e)
        {
            int firstLength = textBoxFirstName.Text.Length;
            int lastLength = textBoxLastName.Text.Length;
            string spacer = string.Empty;

            if ((firstLength > 0) || (lastLength > 0))
            {
                if ((firstLength > 0) && (lastLength > 0))
                {
                    spacer = " ";
                }

                labelGreeting.Text = $"Welcome, {textBoxFirstName.Text}{spacer}{textBoxLastName.Text}!";
                           

                // clear text boxes
                textBoxFirstName.Text = string.Empty;
                textBoxLastName.Text = string.Empty;
            }
            else
            {
                labelGreeting.Text = string.Empty;
            }

            // set focus to First name textbox ready for next entry
            textBoxFirstName.Select();

        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            // labelGreeting.Text = $"X:{e.X} Y:{e.Y}";
        }

        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.SelectAll();
        }

        private void labelGreeting_Click(object sender, EventArgs e)
        {

        }
    }
}
