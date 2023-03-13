using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign07
{
    public partial class ClientEditDialog : Form
    {
        public ClientViewModel ClientVM { get; set; }
        
        public ClientEditDialog()
        {
            InitializeComponent();
        }

        private void ClientEditDialog_Load(object sender, EventArgs e)
        {
            setBindings();
        }

        private void setBindings()
        {
            textBoxClientId.DataBindings.Add("Text", ClientVM, "DisplayClient.ClientId");
            textBoxCompanyName.DataBindings.Add("Text", ClientVM, "DisplayClient.CompanyName");
            textBoxAddress1.DataBindings.Add("Text", ClientVM, "DisplayClient.Address1");
            textBoxAddress2.DataBindings.Add("Text", ClientVM, "DisplayClient.Address2");
            textBoxCity.DataBindings.Add("Text", ClientVM, "DisplayClient.City");
            textBoxProvince.DataBindings.Add("Text", ClientVM, "DisplayClient.Province");
            textBoxPostalCode.DataBindings.Add("Text", ClientVM, "DisplayClient.PostalCode");
            textBoxYTDSales.DataBindings.Add("Text", ClientVM, "DisplayClient.YTDSales");

            checkBoxCreditHold.DataBindings.Add("Checked", ClientVM, "DisplayClient.CreditHold");

            textBoxNotes.DataBindings.Add("Text", ClientVM, "DisplayClient.Notes");

            checkBoxTaxable.DataBindings.Add("Checked", ClientVM, "DisplayClient.IsTaxable");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
