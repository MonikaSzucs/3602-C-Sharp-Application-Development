using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryDemoStarter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelResult.Text = "";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int result = Arithmetic.Add(1200, 375);
            labelResult.Text = $"{result:N0}";
        }
    }

    class Arithmetic
    {
        public static int Add(int one, int two)
        {
            return one + two;
        }
    }
}
