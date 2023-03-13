using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingDemoA
{
    public partial class CalculatorForm : Form
    {
        MultiplyCalculation calculator;

        public CalculatorForm()
        {
            // C# has partial classes which means it spleats in two which has a designer code tha tis already generated for us.
            // Initialized component is given to us auotmatically in the CalculatorForm.Designer.cs

            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            calculator = new MultiplyCalculation();
            setBindingsSimple();
            checkBoxOnPropertyChanged.Checked = false;
        }

        private void clearBindings()
        {
            textBoxOpA.DataBindings.Clear();
            textBoxOpB.DataBindings.Clear();
            textBoxResult.DataBindings.Clear();
        }

        private void setBindingsSimple()
        {

            textBoxOpA.DataBindings.Add("Text", calculator, "OperandA");
            textBoxOpB.DataBindings.Add("Text", calculator, "OperandB");
            textBoxResult.DataBindings.Add("Text", calculator, "Result");

        }

        private void setBindings()
        {
            // true means it follows the format
            // then it tells you when - onPropertyChanged
            // null is 0
            // not null is the hashtags that is formatted
            textBoxOpA.DataBindings.Add("Text", calculator, "OperandA", true, DataSourceUpdateMode.OnPropertyChanged, 0, "#,##0");
            textBoxOpB.DataBindings.Add("Text", calculator, "OperandB", true, DataSourceUpdateMode.OnPropertyChanged, 0, "#,##0");
            textBoxResult.DataBindings.Add("Text", calculator, "Result", true, DataSourceUpdateMode.Never, 0, "#,##0");
        }

        private void checkBoxOnPropertyChanged_CheckedChanged(object sender, EventArgs e)
        {
            clearBindings();

            if (checkBoxOnPropertyChanged.Checked)
            {
                setBindings();
            }
            else
            {
                setBindingsSimple();
            }

            textBoxOpA.Select();
        }

        private void textBoxOpA_TextChanged(object sender, EventArgs e)
        {
            //int.TryParse(textBoxOpA.Text, out int operandA);
            //int.TryParse(textBoxOpB.Text, out int operandB);

            //textBoxResult.Text = (operandA * operandB).ToString();
        }

        private void textBoxOpB_TextChanged(object sender, EventArgs e)
        {
            //int.TryParse(textBoxOpA.Text, out int operandA);
            //int.TryParse(textBoxOpB.Text, out int operandB);

            //textBoxResult.Text = (operandA * operandB).ToString();
        }
    }
}
