using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RadioButtonCheckBox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void radioButtonChecked_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonChecked.Checked)
            {
                checkBoxStatus.CheckState = CheckState.Checked;
            }
            else if (radioButtonUnchecked.Checked)
            {
                checkBoxStatus.CheckState = CheckState.Unchecked;
            }
            else
            {
                checkBoxStatus.CheckState = CheckState.Indeterminate;
            }
        }

        private void checkBoxStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStatus.CheckState == CheckState.Checked)
            {
                radioButtonChecked.Checked = true;
            }
            else if (checkBoxStatus.CheckState == CheckState.Unchecked)
            {
                radioButtonUnchecked.Checked = true;
            }
            else
            {
                radioButtonIndeterminate.Checked = true;
            }
        }

        private void checkBoxButtonsEnable_CheckedChanged(object sender, EventArgs e)
        {
            panelButtons.Enabled = checkBoxButtonsEnable.Checked;
            labelButtonResult.Text = string.Empty;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            radioButtonUnchecked.Checked = true;

            radioButtonRed.Checked = true;
            radioButtonSmall.Checked = true;

            checkBoxButtonsEnable.Checked = true;
            labelButtonResult.Text = string.Empty;
        }

        private void buttonType1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            labelButtonResult.Text = button.Text;
        }
    }
}
