using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxDemo
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

        private void buttonAlertBasic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Basic Alert Message");
        }

        private void buttonAlertEnhanced_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enhanced Alert Message",        // Message Text
                            "Enhanced",                      // Caption Text
                            MessageBoxButtons.OK,            // Buttons
                            MessageBoxIcon.Information);     // Icon
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete Record?",          // Message Text
                                                  "Confirm Delete",          // Caption Text
                                                  MessageBoxButtons.YesNo,   // Buttons
                                                  MessageBoxIcon.Question);  // Icon

            labelResult.Text = result == DialogResult.Yes ? "Yes" : "No";

        }
    }
}
