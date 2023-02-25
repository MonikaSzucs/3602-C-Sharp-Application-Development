using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }
    }

    public class DateValidator
    {
        public DateValidator() { }

        public bool Validate(int year, int month, int day)
        {
            return true;
        }
    }
}
