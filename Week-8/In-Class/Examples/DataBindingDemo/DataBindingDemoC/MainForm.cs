using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingDemoC
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
            //This will work now, as the BindingList will trigger Events
            listBoxLineAmounts.DataSource = totalCalculatorVM.Amounts;

            //This still won't work, as there is still no way to know that the TotalAmount has been updated
            textBoxTotalAmount.DataBindings.Add("Text", totalCalculatorVM, "TotalAmount", true, DataSourceUpdateMode.OnPropertyChanged, 0, "###0");
            
        }

        //private void resetListBox()
        //{
        //    listBoxLineAmounts.DataSource = null;
        //    listBoxLineAmounts.DataSource = totalCalculator.Amounts;
        //}

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

                //No need to reset list, as BindingList has raised an event on Add()
                //resetListBox();
                textBoxLineAmount.Text = "";
                textBoxLineAmount.Select();
            }
        }

        private void buttonCalculateTotal_Click(object sender, EventArgs e)
        {
            textBoxTotalAmount.Text = totalCalculatorVM.TotalAmount.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLineAmount.Text = "";
            textBoxTotalAmount.Text = "";
            totalCalculatorVM.Amounts.Clear();
            textBoxLineAmount.Focus();
            //No need to reset list, as BindingList has raised an event on Clear()
            //resetListBox();
        }

    }
}
