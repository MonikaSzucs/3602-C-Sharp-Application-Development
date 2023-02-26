using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COMP3602Lab07A
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelResult.Text = string.Empty;
        }

        private void buttonC2F_Click(object sender, EventArgs e)
        {
            double inputTemperature;
            double outputTemperature;
            string temperatureUnit;
            string plural;

            // Convert the input to a double.
            if (double.TryParse(textBoxInputTemperature.Text, out inputTemperature))
            {
                labelResult.ForeColor = Color.Black;

                if (sender == buttonC2F) // test which button was clicked
                {
                    outputTemperature = inputTemperature * 1.8 + 32.0;
                    temperatureUnit = "Fahrenheit";
                }
                else
                {
                    outputTemperature = (inputTemperature - 32.0) / 1.8;
                    temperatureUnit = "Celsius";
                }

                plural = Math.Abs(outputTemperature - 1.0) < 0.05 ? "" : "s";

                labelResult.Text = $"{outputTemperature:0.#} degree{plural} {temperatureUnit}";
            }
            else
            {
                displayError("Invalid temperature");
            }

            // Send focus to the TextBox 
            textBoxInputTemperature.Select();

            // Must always call Select() before calling SelectAll() 
            //  even if TextBox already has focus
            //  Select all text in the TextBox.
            textBoxInputTemperature.SelectAll();

        }

        private void displayError(string errorMessage)
        {
            labelResult.ForeColor = Color.Red;
            labelResult.Text = errorMessage;
        }
    }
}
