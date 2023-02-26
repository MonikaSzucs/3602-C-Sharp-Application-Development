using System;
using System.Windows.Forms;

namespace EventDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonClearEvents_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Clear();
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("Form Click");
        }

        private void MainForm_DoubleClick(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("Form Double Click");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("OK Button Click");
        }

        private void buttonOK_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxEvents.Items.Add("OK Button Mouse Click");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("Cancel Button Click");
        }

        private void buttonCancel_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxEvents.Items.Add("Cancel Button Mouse Click");
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("TextBoxName - Text Changed");
        }

        private void labelNamePrompt_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("Name Label Click");
        }

        private void labelNamePrompt_DoubleClick(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("Name Label Double Click");
        }

        private void labelNamePrompt_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxEvents.Items.Add("Name Label Mouse Click");
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            textBoxName.SelectAll();
            listBoxEvents.Items.Add("TextBoxName - Enter");
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("TextBoxName - Leave");
        }

        private void MainForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBoxEvents.Items.Add("Form Mouse Double Click");
        }

        private void listBoxEvents_DoubleClick(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("ListBox Double Click");
        }

        private void listBoxEvents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBoxEvents.Items.Add("ListBox Mouse Double Click");
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                listBoxEvents.Items.Add($"Form Mouse Right Click at: {e.X}, {e.Y}");
            }
            else
            {
                listBoxEvents.Items.Add($"Form Mouse Click at: {e.X}, {e.Y}");
            }
        }

        private void checkBoxAcceptsReturn_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNotes.AcceptsReturn = checkBoxAcceptsReturn.Checked;
            listBoxEvents.Items.Add($"Accepts Return Check Changed: {checkBoxAcceptsReturn.Checked}");
        }

        private void checkBoxAcceptsTab_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNotes.AcceptsTab = checkBoxAcceptsTab.Checked;
            listBoxEvents.Items.Add($"Accepts Tab Check Changed {checkBoxAcceptsTab.Checked}");
        }

        private void textBoxNotes_TextChanged(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("TextBoxNotes - Text Changed");
        }

        private void textBoxNotes_Enter(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("TextBoxNotes - Enter");
        }

        private void textBoxNotes_Leave(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("TextBoxNotes - Leave");
        }

        private void checkBoxCharacterCasing_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxName.CharacterCasing == CharacterCasing.Normal)
            {
                textBoxName.CharacterCasing = CharacterCasing.Upper;
            }
            else
            {
                textBoxName.CharacterCasing = CharacterCasing.Normal;
            }

            listBoxEvents.Items.Add($"Character Casing Check Changed {textBoxName.CharacterCasing}");
        }

        private void labelNotesPrompt_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("Notes Label Click");
        }

        private void labelNotesPrompt_DoubleClick(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("Notes Label Double Click");
        }

        private void labelNotesPrompt_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxEvents.Items.Add("Notes Label Mouse Click");
        }
    }
}
