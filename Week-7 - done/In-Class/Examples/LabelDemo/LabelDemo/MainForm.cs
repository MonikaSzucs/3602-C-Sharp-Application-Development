using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // can have a method to initialize controls
        // set values of controls or clear them
        // everything that happens here happen before the form is rendered
        private void MainForm_Load(object sender, EventArgs e)
        {
            labelAutoSizeTrue.Text = "Labels with AutoSize set to true (default) will grow to the right off the edge of the screen.";
            labelAutoSizeFalse.Text = "Labels with AutoSize set to false will contain the text within the bounds of the control. Note that word wrapping is a built in feature.";
        }

        //private void checkBoxLimitWidth_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (labelAutoSizeTrue.MaximumSize.Width == 0)
        //    {
        //        labelAutoSizeTrue.MaximumSize = new Size(120, 0);
        //    }
        //    else
        //    {
        //        labelAutoSizeTrue.MaximumSize = new Size(0, 0);
        //    }
        //    labelAutoSizeTrue.Refresh();
        //}

        private void buttonSetMaxSizeWidth_Click(object sender, EventArgs e)
        {
            labelAutoSizeTrue.MaximumSize = new Size(120, 0);
        }
    }
}
