using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3602Assign07
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PrintLabel();
        }

        private void PrintLabel()
        {
            List<Client> clientsList = ClientRepository.GetCustomerLocations();
            //string clientInfo = "list: " + clientsList.Count + string.Join(',', clientsList);
            string clientInfo = "";
            foreach(Client client in clientsList)
            {
                clientInfo += client.ToString() + "\n";
            }

            labelDisplay.Text = clientInfo;
        }
    }
}
