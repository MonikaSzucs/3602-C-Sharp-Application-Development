using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorProviderDemoA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (checkBoxUseErrorProvider.Checked)
            {
                validateBetter();
            }
            else
            {
                validate();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validate()
        {
            if (textBoxFirstName.Text == string.Empty)
            {
                MessageBox.Show("Enter a Firstname", "Data Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (textBoxLastName.Text == string.Empty)
            {
                MessageBox.Show("Enter a Lastname", "Data Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!int.TryParse(textBoxAge.Text, out int age))
            {
                MessageBox.Show("Enter Age as a Whole Number", "Data Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validateBetter()
        {
            if (textBoxFirstName.Text == string.Empty)
            {
                errorProvider.SetError(textBoxFirstName, "Enter a Firstname");
            }
            else
            {
                errorProvider.SetError(textBoxFirstName, string.Empty);
            }

            if (textBoxLastName.Text == string.Empty)
            {
                errorProvider.SetError(textBoxLastName, "Enter a Lastname");
            }
            else
            {
                errorProvider.SetError(textBoxLastName, string.Empty);
            }

            if (!int.TryParse(textBoxAge.Text, out int age))
            {
                errorProvider.SetError(textBoxAge, "Enter Age as a Whole Number");
            }
            else
            {
                errorProvider.SetError(textBoxAge, string.Empty);
            }
        }
    }
}
