using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorProviderDemoB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxClientCode, string.Empty);
            errorProvider.SetError(textBoxFirstName, string.Empty);
            errorProvider.SetError(textBoxLastName, string.Empty);
            errorProvider.SetError(textBoxAge, string.Empty);
            errorProvider.SetError(maskedTextBoxPostalCode, string.Empty);

            string regExClientCode = @"^[A-Z]{2}\d{3}$";
            string clientCode = textBoxClientCode.Text;

            if (!Regex.IsMatch(clientCode, regExClientCode))
            {
                errorProvider.SetError(textBoxClientCode, "Client Code should be in the form AA999");
            }

            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                errorProvider.SetError(textBoxFirstName, "Enter First Name");
            }

            if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                errorProvider.SetError(textBoxLastName, "Enter Last Name");
            }

            if (!int.TryParse(textBoxAge.Text, out int age))
            {
                errorProvider.SetError(textBoxAge, "Enter Age as Number");
            }

            string regExCdnPostalCode = @"^[A-Z]\d[A-Z] \d[A-Z]\d$";
            string postalCode = maskedTextBoxPostalCode.Text;

            if (!Regex.IsMatch(postalCode, regExCdnPostalCode))
            {
                errorProvider.SetError(maskedTextBoxPostalCode, "Postal Code Format is Incorrect");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
