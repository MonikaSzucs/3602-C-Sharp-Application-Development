using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingExampleCRUD
{
    public partial class MainForm : Form
    {
        private ProductViewModel productVM;
        private BindingSource productsSource = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                productVM = new ProductViewModel();
                setBindings();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setBindings()
        {
            textBoxQuantity.DataBindings.Add("Text", productVM, "DisplayProduct.Quantity", true, DataSourceUpdateMode.OnValidation, "0", "#,##0;(#,##0);0");
            textBoxSku.DataBindings.Add("Text", productVM, "DisplayProduct.Sku", false, DataSourceUpdateMode.OnValidation, "");
            textBoxDescription.DataBindings.Add("Text", productVM, "DisplayProduct.Description");
            textBoxCost.DataBindings.Add("Text", productVM, "DisplayProduct.Cost", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            checkBoxTaxable.DataBindings.Add("Checked", productVM, "DisplayProduct.Taxable");

            productsSource.DataSource = productVM.Products;
            listBoxProducts.DataSource = productsSource;
            listBoxProducts.DisplayMember = "Sku";

        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Math.Max(0, listBoxProducts.SelectedIndex);
            Product product = productVM.Products[selectedIndex];
            productVM.DisplayProduct = product;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBoxProducts.SelectedIndex;

                Product product = productVM.DisplayProduct;
                int rowsAffected;

                if (product.ProductId > 0)
                {
                    rowsAffected = ProductRepository.UpdateProduct(product);
                }
                else
                {
                    rowsAffected = ProductRepository.AddProduct(product);
                }

                if (rowsAffected > 0)
                {
                    refreshListBox();
                    listBoxProducts.SelectedIndex = index;
                }
                else
                {
                    MessageBox.Show("No DB changes were made", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonNewProduct_Click(object sender, EventArgs e)
        {
            productVM.DisplayProduct = new Product();
            textBoxQuantity.Select();
            textBoxQuantity.SelectAll();
        }

        
        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = productVM.DisplayProduct;
                ProductRepository.DeleteProduct(product);
                refreshListBox();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshListBox()
        {
            productVM.Products = ProductRepository.GetProducts();
            listBoxProducts.DataSource = productVM.Products;
            listBoxProducts.DisplayMember = "Sku";
        }
    }
}
