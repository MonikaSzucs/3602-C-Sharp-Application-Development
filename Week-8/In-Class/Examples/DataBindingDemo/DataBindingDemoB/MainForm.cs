using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingDemoB
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
            //If we try to do this, it won't work, as List<T> won't invoke events when it changes
            //listBoxLineAmounts.DataSource = totalCalculatorVM.Amounts;

            //Can't bind to properties of lists
            //textBoxTotalAmount.DataBindings.Add("Text", totalCalculatorVM, "Amounts.TotalAmount");

            //This won't work either, as there is no way to know that the TotalAmount has been updated
            //textBoxTotalAmount.DataBindings.Add("Text", totalCalculatorVM, "TotalAmount");
        }

        
        /// <summary>
        /// Reset the whole list with fresh data
        /// </summary>
        private void resetListBox()
        {
            listBoxLineAmounts.DataSource = null;
            listBoxLineAmounts.DataSource = totalCalculatorVM.Amounts;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            totalCalculatorVM = new TotalCalculatorViewModel();
            setBindings();
        }

        private void buttonAddAmount_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBoxLineAmount.Text.Replace(",", ""), out int amount))
            {
                totalCalculatorVM.Amounts.Add(amount);

                //Need to update the list as it doesn't know a value has been added
                resetListBox();
                textBoxLineAmount.Text = "";
                textBoxLineAmount.Select();
            }        
        }

        private void buttonCalculateTotal_Click(object sender, EventArgs e)
        {
            textBoxTotalAmount.Text = totalCalculatorVM.Amounts.TotalAmount.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLineAmount.Text = "";
            textBoxTotalAmount.Text = "";
            totalCalculatorVM.Amounts.Clear();
            textBoxLineAmount.Focus();
            //Need to update the list as it doesn't know the list has been cleared
            resetListBox();
        }

    }
}
