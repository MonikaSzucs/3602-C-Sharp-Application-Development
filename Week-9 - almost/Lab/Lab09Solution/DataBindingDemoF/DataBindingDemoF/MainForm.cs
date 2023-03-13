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
    public partial class MainForm : Form
    {
        private ProductViewModel productVM;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelCount.Text = "";
            productVM = new ProductViewModel();
            setBindings();
            setupDataGridView();
            
        }

        private void setBindings()
        {

            labelCount.DataBindings.Add("Text", productVM, "Count");           


            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.DataSource = productVM.ProductsSource;
        }

        private void setupDataGridView()
        {
            // configure for readonly 
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.MultiSelect = false;
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewProducts.AllowUserToOrderColumns = false;
            dataGridViewProducts.AllowUserToResizeColumns = false;
            dataGridViewProducts.AllowUserToResizeRows = false;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dataGridViewProducts.RowHeadersVisible = false;

            // add columns

            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Name = "id";
            id.DataPropertyName = "ProductId";
            id.HeaderText = "Id";
            id.Width = 40;
            id.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            id.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewProducts.Columns.Add(id);

            DataGridViewTextBoxColumn qty = new DataGridViewTextBoxColumn();
            qty.Name = "qty";
            qty.DataPropertyName = "Quantity";
            qty.HeaderText = "Quantity";
            qty.Width = 60;
            qty.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            qty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            qty.DefaultCellStyle.Format = "N0";
            qty.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewProducts.Columns.Add(qty);

            DataGridViewTextBoxColumn sku = new DataGridViewTextBoxColumn();
            sku.Name = "sku";
            sku.DataPropertyName = "Sku";
            sku.HeaderText = "Sku";
            sku.Width = 70;
            sku.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewProducts.Columns.Add(sku);

            DataGridViewTextBoxColumn desc = new DataGridViewTextBoxColumn();
            desc.Name = "desc";
            desc.DataPropertyName = "Description";
            desc.HeaderText = "Description";
            desc.Width = 150;
            desc.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewProducts.Columns.Add(desc);

            DataGridViewTextBoxColumn cost = new DataGridViewTextBoxColumn();
            cost.Name = "cost";
            cost.DataPropertyName = "Cost";
            cost.HeaderText = "Cost";
            cost.Width = 80;
            cost.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            cost.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            cost.DefaultCellStyle.Format = "N2";
            cost.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewProducts.Columns.Add(cost);

            DataGridViewTextBoxColumn ext = new DataGridViewTextBoxColumn();
            ext.Name = "cost";
            ext.DataPropertyName = "Extension";
            ext.HeaderText = "Extension";
            ext.Width = 80;
            ext.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            ext.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ext.DefaultCellStyle.Format = "N2";
            ext.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewProducts.Columns.Add(ext);

            DataGridViewCheckBoxColumn tax = new DataGridViewCheckBoxColumn();
            tax.Name = "taxable";
            tax.DataPropertyName = "IsTaxable";
            tax.HeaderText = "Taxable";
            tax.Width = 60;
            tax.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tax.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewProducts.Columns.Add(tax);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {

            ShowEditDialog(true);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            ShowEditDialog(false);
        }

        private void dataGridViewProducts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEditDialog(false);
        }

        private void ShowEditDialog(bool isNew)
        {
            Product product;
            int index = dataGridViewProducts.CurrentRow.Index;

            if (isNew)
            {
                product = new Product();
            } else {
               
                product = (Product)productVM.ProductsSource[index];
            }

            //Set the display product then launch the dialog
            productVM.DisplayProduct = product;
            using (ProductEditDialog dlg = new ProductEditDialog())
            {
                dlg.ProductVM = this.productVM;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    //If user clicked OK, then get the display product
                    //and then add or update it in the list
                    product = productVM.DisplayProduct;

                    if (product.ProductId == default)
                    {
                        //Mimic database assigning ID
                        product.ProductId = productVM.ProductsSource.Count + 1;
                        productVM.ProductsSource.Add(product);
                    }
                    else
                    {
                        productVM.ProductsSource[index] = product;
                    }
                }
            }
        }
    }
}
