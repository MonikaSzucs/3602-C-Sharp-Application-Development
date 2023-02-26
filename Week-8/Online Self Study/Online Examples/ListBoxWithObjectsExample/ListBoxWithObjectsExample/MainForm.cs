using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBoxWithObjectsExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            populateListBox(listBoxNames);
            
            // Since we populated the ListBox with non-string objects, how does it
            // know what to display?
            // Answer: we can tell it how to display these
            // objects by telling it which public property to look for in the Person 
            // class. You give it a string, which is the name of the property.
            //
            // Note: The DisplayMember is set to a non-empty string then it is used
            //       instead of the object's ToString method.
            listBoxNames.DisplayMember = "LastName";
           
            // Programmatically select the first ListBox item.
            // Note: This will fire the SelectedIndexChanged event, which is actually
            //       a good thing in this case. 
            listBoxNames.SelectedIndex = 0;

        }

        private void populateListBox(ListBox listBox)
        {
            // Clear ListBox first so that this method can be called again later if
            // necessary.
            listBox.Items.Clear();

            // Create some Person objects and add them to the ListBox.
            listBox.Items.Add(new Person("Joan", "Heart", new DateTime(1960, 5, 25)));
            listBox.Items.Add(new Person("Greg", "Taylor", new DateTime(1965, 6, 24)));
            listBox.Items.Add(new Person("Amber", "Black", new DateTime(1972, 2, 2)));
            listBox.Items.Add(new Person("William", "Garcia", new DateTime(1991, 9, 1)));
            listBox.Items.Add(new Person("Cindy", "Gold", new DateTime(2000, 1, 14)));
            listBox.Items.Add(new Person("Chris", "Smith", new DateTime(1957, 8, 30)));
            listBox.Items.Add(new Person("Jennifer", "Lancing", new DateTime(1939, 1, 27)));
            listBox.Items.Add(new Person("Hardeep", "Singh", new DateTime(1969, 12, 11)));
        }

      
        private void listBoxNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Make sure something is selected in the list before proceeding.  We
            // could also check SelectedIndex to make sure it's not -1.
            if (listBoxNames.SelectedItem == null)
            {
                return;
            }
            
            Person selectedPerson = listBoxNames.SelectedItem as Person;

            if (selectedPerson != null)
            {
                displayPersonDetails(selectedPerson);    
            }
        }

        private void displayPersonDetails(Person person)
        {
            bool valid = person != null;

            textBoxFirstName.Text = valid ? person.FirstName : string.Empty;
            textBoxLastName.Text = valid ? person.LastName : string.Empty;
            textBoxAge.Text = valid ? person.Age.ToString() : string.Empty;
            textBoxBirthDate.Text = valid ? person.BirthDate.ToString("ddd MMM d, yyyy") : string.Empty;
        }
    }
}
