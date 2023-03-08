using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingDemoD
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
            //textBoxLineAmount.DataBindings.Add("Text", totalCalculator, "CurrentAmount");

            textBoxTotalAmount.DataBindings.Add("Text", totalCalculatorVM, "TotalAmount");
            listBoxLineAmounts.DataSource = totalCalculatorVM.Amounts;

            Debug.WriteLine("setting bindings");
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
                Debug.WriteLine("adding amount");
                //totalCalculator.AddCurrentAmount();
                totalCalculatorVM.Amounts.Add(amount);
                Debug.WriteLine("added amount");
                //No need to reset list, as BindingList has raised an event on Add()
                //resetListBox();
                textBoxLineAmount.Text = "";
                textBoxLineAmount.Focus();
            }
        }

        //private void buttonCalculateTotal_Click(object sender, EventArgs e)
        //{
        //    //textBoxTotalAmount.Text = totalCalculator.TotalAmount.ToString();
        //}

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLineAmount.Text = "";
            //textBoxTotalAmount.Text = "";
            totalCalculatorVM.Amounts.Clear();
            textBoxLineAmount.Focus();
            //No need to reset list, as BindingList has raised an event on Clear()
            //resetListBox();
        }

    }
}
