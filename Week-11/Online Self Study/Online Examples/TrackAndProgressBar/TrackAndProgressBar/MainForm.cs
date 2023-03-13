using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrackAndProgressBar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void trackBarHorizontal_Scroll(object sender, EventArgs e)
        {
            progressBarHorizontal.Value = trackBarHorizontal.Value * 2;
            labelProgress.Text = $"{progressBarHorizontal.Value}%";
        }

        private void trackBarVertical_Scroll(object sender, EventArgs e)
        {
            progressBarVertical.Value = trackBarVertical.Value * 10;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelProgress.Text = $"{progressBarHorizontal.Value}%";
            progressBarHorizontal.ResetText();
        }
    }
}
