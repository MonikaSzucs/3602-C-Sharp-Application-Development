using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CommonDialogExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a dialog to ask the user for the full path of a file.
            OpenFileDialog dlg = new OpenFileDialog();

            // Initialize the dialog with some values before displaying it.
            dlg.Title = "Open File";
            dlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.InitialDirectory =
                        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Display the dialog.
            if (dlg.ShowDialog() == DialogResult.OK && dlg.FileName != string.Empty)
            {
                try
                {
                    // Open and display the file.
                    StreamReader reader = new StreamReader(dlg.FileName);
                    textBoxDocument.Text = reader.ReadToEnd();
                    reader.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            dlg.Dispose();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // or this.Close();
        }

        private void changeBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = textBoxDocument.BackColor;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxDocument.BackColor = dlg.Color;
            }

            dlg.Dispose();
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();

            dlg.Font = textBoxDocument.Font;
            dlg.Color = textBoxDocument.ForeColor;
            dlg.ShowColor = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxDocument.Font = dlg.Font;
                textBoxDocument.ForeColor = dlg.Color;
            }

            dlg.Dispose();
        }
    }
}
