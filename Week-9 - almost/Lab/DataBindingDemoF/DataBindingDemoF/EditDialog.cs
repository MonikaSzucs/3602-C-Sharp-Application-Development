using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingDemoF
{
    public partial class EditDialog : Form
    {
        private ProductViewModel productVM;
        public string Quantity { get; set; }
        public string SKU { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public decimal Extension { get; set; }
        public bool Taxable { get; set; }
        
        public EditDialog()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            textBoxQuantity.Text = this.Quantity.ToString();
            textBoxSKU.Text = this.SKU;
            textBoxDescription.Text = this.Description;
            textBoxCost.Text = this.Cost.ToString();
            textBoxExtension.Text = this.Extension.ToString();
            checkBoxTaxable.Checked = this.Taxable;

            setBindings();
        }

        private void setBindings()
        {
            textBoxSKU.DataBindings.Add("Text", productVM, "DisplayProduct.SKU");

            textBoxDescription.DataBindings.Add("Text", productVM, "DisplayProduct.Description");

            textBoxQuantity.DataBindings.Add("Text", productVM, "DisplayProduct.Quantity",
                                            true, DataSourceUpdateMode.OnValidation, "0", "#,##0;(#,##0);0");

            textBoxCost.DataBindings.Add("Text", productVM, "DisplayProduct.Cost",
                                          true, DataSourceUpdateMode.OnValidation,
                                          "0.00", "#,##0.00;(#,##0.00);0.00");

            textBoxExtension.DataBindings.Add("Text", productVM, "DisplayProduct.ExtensionPrice",
                                          true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");

            checkBoxTaxable.DataBindings.Add("Checked", productVM, "DisplayProduct.IsTaxable");

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(validate())
            {
                this.Quantity = textBoxQuantity.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Quantity cannot be less than 0.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private bool validate() => Convert.ToInt32(textBoxQuantity.Text) >= 0;

    }
}
