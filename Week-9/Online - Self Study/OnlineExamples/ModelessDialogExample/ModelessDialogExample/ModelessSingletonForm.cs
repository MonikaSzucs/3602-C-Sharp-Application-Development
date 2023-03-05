using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModelessDialogExample
{
    public partial class ModelessSingletonForm : Form
    {
        private static ModelessSingletonForm instance;     // declare private static field of form type
        
        private ModelessSingletonForm()                    // scope default ctor private
        {
            InitializeComponent();
        }

        public static ModelessSingletonForm CreateForm()   // create public static method with form type return
        {
            if (instance == null)
            {
                instance = new ModelessSingletonForm();
            }

            return instance;
        }

        private void ModelessSingletonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null; // explicitly set form instance to null as form closes
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
