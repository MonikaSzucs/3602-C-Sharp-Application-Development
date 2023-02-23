using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimerNTooltip
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelTimeDisplay.Text = DateTime.Now.ToString("h:mm:ss tt");
            timerClock.Interval = 1000;
            timerClock.Enabled = true;
            tipMain.SetToolTip(labelTimeDisplay, "Current System Time");
            tipMain.SetToolTip(buttonStartStop, "Stop the Display Timer");
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            labelTimeDisplay.Text = $"{DateTime.Now:h:mm:ss tt}"; 
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (buttonStartStop.Text == "&Stop")
            {
                buttonStartStop.Text = "&Start";
                timerClock.Stop();
                tipMain.SetToolTip(buttonStartStop, "Start the Display Timer");
                tipMain.SetToolTip(labelTimeDisplay, "System Time (Frozen)");
            }
            else
            {
                buttonStartStop.Text = "&Stop";
                timerClock.Start();
                tipMain.SetToolTip(buttonStartStop, "Stop the Display Timer");
                tipMain.SetToolTip(labelTimeDisplay, "Current System Time");
            }
        }
    }
}
