using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalDialogDemo
{
    public partial class EditDialog : Form
    {
        public string UserName { get; set; }

        public EditDialog()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            textBoxUserName.Text = this.UserName;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                this.UserName = textBoxUserName.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("User Name cannot be empty.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private bool validate() => textBoxUserName.Text.Length > 0; // expression bodied method
        //{
        //    return textBoxUserName.Text.Length > 0;
        //}
}
}
