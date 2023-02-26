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

namespace COMP3602Lab07
{
    public enum TemperatureConversion
    {
        CelsiusToFahrenheit,
        FahrenheitToCelsius
    }
    
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

        private void buttonCtoF_Click(object sender, EventArgs e)
        {
            convertTemperature(TemperatureConversion.CelsiusToFahrenheit);
        }

        private void buttonFtoC_Click(object sender, EventArgs e)
        {
            convertTemperature(TemperatureConversion.FahrenheitToCelsius);
        }

        // Converting the temperature to Fahrenheit or Celsius
        private void convertTemperature(TemperatureConversion conversion)
        {
            double inputTemperature;
            double outputTemeprature;
            string temperatureUnit;
            string plural;

            if(double.TryParse(textBoxInputTemperature.Text, out inputTemperature))
            {
                // Set label to default of black colour
                labelResult.ForeColor = Color.Black;

                if(conversion == TemperatureConversion.CelsiusToFahrenheit)
                {
                    outputTemeprature = inputTemperature * 1.8 + 32.0;
                    temperatureUnit= "Fahrenheit";
                }
                else
                {
                    outputTemeprature = (inputTemperature - 32.0) / 1.8;
                    temperatureUnit = "Celsius";
                }

                plural = Math.Abs(outputTemeprature - 1.0) < 0.05 ? "" : "s";
                labelResult.Text = $"{outputTemeprature:0.#} degree{plural} {temperatureUnit}";
            }
            else
            {
                displayError("Invlid temperature");
            }

            // Send fous to the TextBox
            textBoxInputTemperature.Select();

            // Call the Select() before calling SelectAll()
            // You want to have focus first on the TextBox
            // Then select all the text in the TextBox
            textBoxInputTemperature.SelectAll();
        }

        // Stylize and display error message
        private void displayError(string errorMessage)
        {
            labelResult.ForeColor = Color.Red;
            labelResult.Text = errorMessage;
        }
    }
}
