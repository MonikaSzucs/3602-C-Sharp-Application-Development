using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingDemoE
{
    public partial class MainForm : Form
    {
        TotalCalculatorViewModel totalCalculatorVM;
        public MainForm()
        {
            InitializeComponent();
        }

        private void setBindings()
        {
            textBoxTotalAmount.DataBindings.Add("Text", totalCalculatorVM, "TotalAmount");
            textBoxAverage.DataBindings.Add("Text", totalCalculatorVM, "Average",true, DataSourceUpdateMode.Never,null, "#.00");
            textBoxCount.DataBindings.Add("Text", totalCalculatorVM, "Count");
            listBoxLineAmounts.DataSource = totalCalculatorVM.Amounts;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            totalCalculatorVM = new TotalCalculatorViewModel();
            setBindings();
        }

        private void buttonAddAmount_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxLineAmount.Text.Replace(",", ""), out int amount))
            {
                totalCalculatorVM.Amounts.Add(amount);
                textBoxLineAmount.Text = "";
                textBoxLineAmount.Focus();
            }
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLineAmount.Text = "";
            totalCalculatorVM.Amounts.Clear();
            textBoxLineAmount.Focus();
        }

    }
}
