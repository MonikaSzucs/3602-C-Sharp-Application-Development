// Monika Szucs
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
    public partial class ProductEditDialog : Form
    {
        public ProductViewModel ProductVM { get; set; }
        public ProductEditDialog()
        {
            InitializeComponent();
        }

        private void ProductEditDialog_Load(object sender, EventArgs e)
        {
            setBindings();
        }

        private void setBindings()
        {
            textBoxQuantity.DataBindings.Add("Text", ProductVM, "DisplayProduct.Quantity",
                                          true, DataSourceUpdateMode.OnValidation, "0", "#,##0;(#,##0);0");

            textBoxSku.DataBindings.Add("Text", ProductVM, "DisplayProduct.Sku");

            textBoxDescription.DataBindings.Add("Text", ProductVM, "DisplayProduct.Description");

            textBoxCost.DataBindings.Add("Text", ProductVM, "DisplayProduct.Cost",
                                          true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");

            textBoxExtension.DataBindings.Add("Text", ProductVM, "DisplayProduct.Extension",
                                          true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");

            checkBoxTaxable.DataBindings.Add("Checked", ProductVM, "DisplayProduct.IsTaxable");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
