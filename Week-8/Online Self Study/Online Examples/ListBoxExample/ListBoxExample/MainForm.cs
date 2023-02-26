using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBoxExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // First, some input validation.
            if (textBoxName.Text == string.Empty)
            {
                MessageBox.Show("Enter a name first"
                              , "Add Name"
                              , MessageBoxButtons.OK
                              , MessageBoxIcon.Information);
            }
            else
            {
                // Add name from the TextBox into the ListBox. By default,
                // the new ListBox item will be added to the end of the list.
                listBoxNames.Items.Add(textBoxName.Text);
            }

            // Send the input focus to the TextBox control and select any text it has.
            textBoxName.Select();
            textBoxName.SelectAll();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            object selectedItem = listBoxNames.SelectedItem;

            // First, some input validation. In this case, the 
            // input is the selected list index. An index
            // of -1 indicates that nothing is selected.
            if (listBoxNames.Items.Count == 0)
            {
                MessageBox.Show("The list is empty"
                              , "Remove Name"
                              , MessageBoxButtons.OK
                              , MessageBoxIcon.Information);
            }
            else if (listBoxNames.SelectedIndex == -1)
            {
                MessageBox.Show("Select a name to remove first"
                              , "Remove Name"
                              , MessageBoxButtons.OK
                              , MessageBoxIcon.Information);
            }
            else
            {
                // Remove the selected item from the list.
                listBoxNames.Items.Remove(selectedItem);
            }
        }
    }
}
