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
    public partial class MainForm : Form
    {
        private ClientViewModel clientVM;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelCountTotal.Text = "";
            labelClientLegend.Text = string.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n",
                                        "Total YTDSales:",
                                        "PST:",
                                        "GST:",
                                        "Total:");

            clientVM = new ClientViewModel(0.07m, 0.05m);
            setBindings();
            setupDataGridView();
        }

        private void setBindings()
        {
            textBoxCompanyName.DataBindings.Add("Text", clientVM, "DisplayClient.CompanyName");
            textBoxAddress1.DataBindings.Add("Text", clientVM, "DisplayClient.Address1");
            textBoxAddress2.DataBindings.Add("Text", clientVM, "DisplayClient.Address2");
            textBoxCity.DataBindings.Add("Text", clientVM, "DisplayClient.City");
            textBoxProvince.DataBindings.Add("Text", clientVM, "DisplayClient.Province");
            textBoxPostalCode.DataBindings.Add("Text", clientVM, "DisplayClient.PostalCode");
            textBoxYTDSales.DataBindings.Add("Text", clientVM, "DisplayClient.YTDSales");

            checkBoxCreditHold.DataBindings.Add("Text", clientVM, "DisplayClient.CreditHold");

            textBoxNotes.DataBindings.Add("Text", clientVM, "DisplayClient.Notes");

            checkBoxIsTaxable.DataBindings.Add("Text", clientVM, "DisplayClient.IsTaxable");

            labelCountTotal.DataBindings.Add("Text", clientVM, "Count");
            labelTotals.DataBindings.Add("Text", clientVM, "Totals");

            dataGridViewClients.AutoGenerateColumns = false;
            dataGridViewClients.DataSource = clientVM.ClientSource;
        }

        private void setupDataGridView()
        {
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.MultiSelect = false;
            dataGridViewClients.AllowUserToAddRows = false;
            dataGridViewClients.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewClients.AllowUserToOrderColumns = false;
            dataGridViewClients.AllowUserToResizeColumns = false;
            dataGridViewClients.AllowUserToResizeRows = false;
            dataGridViewClients.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dataGridViewClients.RowHeadersVisible = false;

            // Add columns

            DataGridViewTextBoxColumn companyName = new DataGridViewTextBoxColumn();
            companyName.Name = "companyName";
            companyName.DataPropertyName = "CompanyName";
            companyName.HeaderText = "CompanyName";
            companyName.Width = 350;
            companyName.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(companyName);

            DataGridViewTextBoxColumn address1 = new DataGridViewTextBoxColumn();
            address1.Name = "address1";
            address1.DataPropertyName = "Address1";
            address1.HeaderText = "Address1";
            address1.Width = 350;
            address1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(address1);

            DataGridViewTextBoxColumn address2 = new DataGridViewTextBoxColumn();
            address2.Name = "address2";
            address2.DataPropertyName = "Address2";
            address2.HeaderText = "Address2";
            address2.Width = 200;
            address2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(address2);

            DataGridViewTextBoxColumn city = new DataGridViewTextBoxColumn();
            city.Name = "city";
            city.DataPropertyName = "City";
            city.HeaderText = "City";
            city.Width = 150;
            city.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(city);

            DataGridViewTextBoxColumn province = new DataGridViewTextBoxColumn();
            province.Name = "province";
            province.DataPropertyName = "Province";
            province.HeaderText = "Province";
            province.Width = 150;
            province.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(province);

            DataGridViewTextBoxColumn postalCode = new DataGridViewTextBoxColumn();
            postalCode.Name = "postalCode";
            postalCode.DataPropertyName = "PostalCode";
            postalCode.HeaderText = "PostalCode";
            postalCode.Width = 150;
            postalCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(postalCode);

            DataGridViewTextBoxColumn ytdSales = new DataGridViewTextBoxColumn();
            ytdSales.Name = "ytdSales";
            ytdSales.DataPropertyName = "YTDSales";
            ytdSales.HeaderText = "YTDSales";
            ytdSales.Width = 150;
            ytdSales.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            ytdSales.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ytdSales.DefaultCellStyle.Format = "N2";
            ytdSales.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(ytdSales);

            DataGridViewTextBoxColumn creditHold = new DataGridViewTextBoxColumn();
            creditHold.Name = "creditHold";
            creditHold.DataPropertyName = "CreditHold";
            creditHold.HeaderText = "CreditHold";
            creditHold.Width = 150;
            creditHold.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            creditHold.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            creditHold.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(creditHold);

            DataGridViewTextBoxColumn notes = new DataGridViewTextBoxColumn();
            notes.Name = "notes";
            notes.DataPropertyName = "Notes";
            notes.HeaderText = "Notes";
            notes.Width = 250;
            notes.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(notes);

            DataGridViewTextBoxColumn isTaxable = new DataGridViewTextBoxColumn();
            isTaxable.Name = "isTaxable";
            isTaxable.DataPropertyName = "IsTaxable";
            isTaxable.HeaderText = "IsTaxable";
            isTaxable.Width = 150;
            isTaxable.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            isTaxable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            isTaxable.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(isTaxable);
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridViewClients.CurrentRow.Index;

            Client client = (Client)clientVM.ClientSource[index];
            clientVM.DisplayClient = client;
        }

    }
}
