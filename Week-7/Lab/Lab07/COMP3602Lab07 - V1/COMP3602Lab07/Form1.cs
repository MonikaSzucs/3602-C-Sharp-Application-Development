// Monika Szucs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace COMP3602Lab07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formButtonConvertFToC_Click(object sender, EventArgs e)
        {
            int numberLength = textBox.Text.Length;
            string text = textBox.Text;
            double fahrenheit;
            labelConvertedTemperature.Font = new Font(labelConvertedTemperature.Font, FontStyle.Bold);

            // checking if something is entered in textBox
            if (numberLength > 0)
            {
                // converting string to double and checking if a number
                if (double.TryParse(text, out fahrenheit))
                {
                    double celcius = (fahrenheit - 32) / 1.8;
                    labelConvertedTemperature.ForeColor = Color.Black;

                    // check for decimal places if not a 0
                    if (celcius % 1 == 0)
                    {
                        labelConvertedTemperature.Text = $"{celcius} degrees Celcius";
                    }
                    else
                    {
                        labelConvertedTemperature.Text = $"{celcius:N1} degrees Celcius";
                    }
                }
                else // if not a number throw an error message
                {
                    labelConvertedTemperature.Text = "Invalid temperature";
                    labelConvertedTemperature.ForeColor = Color.Red;
                }
            }
            textBox.Focus();
            textBox.Select(0, textBox.Text.Length);
        }

        private void formButtonConvertCToF_Click(object sender, EventArgs e)
        {
            int numberLength = textBox.Text.Length;
            string text = textBox.Text;
            double celsiusValue;
            labelConvertedTemperature.Font = new Font(labelConvertedTemperature.Font, FontStyle.Bold);

            // checking if something is entered in textBox
            if (numberLength > 0)
            {
                // converting string to double and checking if a number
                if (double.TryParse(text, out celsiusValue))
                {
                    double fahrenheit = (celsiusValue * 1.8) + 32;
                    labelConvertedTemperature.ForeColor = Color.Black;

                    // check for decimal places if not a 0
                    if (fahrenheit % 1 == 0)
                    {
                        labelConvertedTemperature.Text = $"{fahrenheit} degrees Fahrenheit";
                    }
                    else 
                    {
                        labelConvertedTemperature.Text = $"{fahrenheit:N1} degrees Fahrenheit";
                    }
                }
                else // if not a number throw an error message
                {
                    labelConvertedTemperature.Text = "Invalid temperature";
                    labelConvertedTemperature.ForeColor = Color.Red;
                }
            }
            textBox.Focus();
            textBox.Select(0, textBox.Text.Length);
        }
    }
}
