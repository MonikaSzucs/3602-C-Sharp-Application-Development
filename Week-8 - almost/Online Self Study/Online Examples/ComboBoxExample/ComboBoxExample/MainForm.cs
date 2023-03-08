using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelPersonName.Text = string.Empty;

            populateComboBox(comboBoxSimple);
            populateComboBox(comboBoxDropDown);
            populateComboBox(comboBoxDropDownList);
        }

        private void populateComboBox(ComboBox comboBox)
        {
            // Clear ComboBox first so that this method can be called again later if
            // necessary.
            comboBox.Items.Clear();

            // Create some Person objects and add them to the ListBox.
            comboBox.Items.Add(new Person("Joan", "Heart", new DateTime(1960, 5, 25)));
            comboBox.Items.Add(new Person("Greg", "Taylor", new DateTime(1965, 6, 24)));
            comboBox.Items.Add(new Person("Amber", "Black", new DateTime(1972, 2, 2)));
            comboBox.Items.Add(new Person("William", "Garcia", new DateTime(1991, 9, 1)));
            comboBox.Items.Add(new Person("Cindy", "Gold", new DateTime(2000, 1, 14)));
            comboBox.Items.Add(new Person("Chris", "Smith", new DateTime(1957, 8, 30)));
            comboBox.Items.Add(new Person("Jennifer", "Lancing", new DateTime(1939, 1, 27)));
            comboBox.Items.Add(new Person("Hardeep", "Singh", new DateTime(1969, 12, 11)));
        }

        private void comboBoxSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;

            if (combo != null && combo.SelectedItem != null)
            {
                Person selectedPerson = combo.SelectedItem as Person;

                if (selectedPerson != null)
                {
                    labelPersonName.Text = selectedPerson.FullName;
                }
            }
            else
            {
                return;
            }
        }
    }
}
