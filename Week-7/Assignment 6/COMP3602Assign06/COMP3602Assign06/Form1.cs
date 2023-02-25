// Monika Szucs
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3602Assign06
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void buttonCheckDate_Click(object sender, EventArgs e)
        {
            int inputYear;
            int inputMonth;
            int inputDay;
            labelResult.Font = new Font(labelResult.Font, FontStyle.Bold);

            if (int.TryParse(textBoxYear.Text, out inputYear) && int.TryParse(textBoxMonth.Text, out inputMonth) && int.TryParse(textBoxDay.Text, out inputDay))
            {

                bool check = DateValidator.Validated(textBoxYear.Text, textBoxMonth.Text, textBoxDay.Text);

                // if valide date then make sure to display the text in black
                if(check == true)
                {
                    labelResult.ForeColor = Color.Black;
                    labelResult.Text = "Valid";
                }
                else // if the date values passed not valid
                {
                    displayError();
                }
            }
            else
            {
                displayError();
            }

            textBoxYear.Select();
            textBoxYear.SelectAll();

        }

        // If the value entered is not a number display an error
        private void displayError()
        {
            labelResult.ForeColor = Color.Red;
            labelResult.Text = "Not Valid";  
        }

        private void labelResult_MouseEnter(object sender, EventArgs e)
        {
            if(labelResult.Text == "Valid")
            {
                toolTipValid.Show("Entered Date is Valid", labelResult);
            } else
            {
                toolTipValid.Show("Entered Date is Not Valid", labelResult);
            }
            
        }

        private void labelResult_MouseLeave(object sender, EventArgs e)
        {
            toolTipValid.Show("", labelResult);
        }
    }

    // Date Validator Class
    public class DateValidator
    {
        public DateValidator() { }

        // Checking the year, month and day values passed
        public static bool Validated(string year, string month, string day)
        {

            DateTime dt;
            bool valid = false;
            int yearInteger = Int32.Parse(year);
            string dateFormat = month + "/" + day + "/" + year;

            // don't worry about leap years
            // make sure its greater than or equal to 1900
            if (yearInteger >= 1900)
            {
                valid = DateTime.TryParseExact(dateFormat, "M/d/yyyy", null, DateTimeStyles.None, out dt) == true;
            }
            
            return valid;
        }
    }
}
