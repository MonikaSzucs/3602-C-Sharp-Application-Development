using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week11OnlineDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelDomainValue.Text = string.Empty;
            labelNumericValue.Text = string.Empty;

            domainUpDownNumbers.Items.Add("One");
            domainUpDownNumbers.Items.Add("Two");
            domainUpDownNumbers.Items.Add("Three");
            domainUpDownNumbers.Items.Add("Four");
            domainUpDownNumbers.Items.Add("Five");
            domainUpDownNumbers.Items.Add("Six");
        }

        private void linkLabelDirectory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\");
        }

        private void linkLabelWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // change LinkColor after it has been clicked
            linkLabelWeb.LinkVisited = true;
            System.Diagnostics.Process.Start("chrome", @"http://www.bcit.ca");
        }

        private void linkLabelApp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void domainUpDownNumbers_SelectedItemChanged(object sender, EventArgs e)
        {
            labelDomainValue.Text = domainUpDownNumbers.SelectedItem as string;
        }

        private void numericUpDownPages_ValueChanged(object sender, EventArgs e)
        {
            // numeric updown value returns a decimal type
            //   so must do an explicit cast to int
            int value = (int) numericUpDownPages.Value;
            value *= 2;
            labelNumericValue.Text = $"{value}";
        }
    }
}
