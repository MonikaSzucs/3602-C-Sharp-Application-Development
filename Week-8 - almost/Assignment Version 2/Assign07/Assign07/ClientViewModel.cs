using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign07
{
    class ClientViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public readonly decimal GstRate;
        public readonly decimal PstRate;

        private readonly ClientList clients;
        private Client displayClient;

        public BindingSource ClientSource { get; }

        public ClientViewModel(decimal gstRate, decimal pstRate)
        {
            GstRate = gstRate;
            PstRate = pstRate;

            clients = ClientRepository.GetClients(GstRate, PstRate);
            Console.WriteLine(clients.ToString());
            ClientSource = new BindingSource();
            ClientSource.DataSource = clients;
            ClientSource.ListChanged += ClientSource_ListChanged;
            DisplayClient = new Client(GstRate, PstRate);
        }

        private void ClientSource_ListChanged(Object sender, ListChangedEventArgs e)
        {
            OnPropertyChanged("Count");
            OnPropertyChanged("Totals");
        }

        protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Client DisplayClient
        {
            get { return displayClient; }
            set
            {
                displayClient = new Client(GstRate, PstRate)
                {
                    CompanyName = value.CompanyName,
                    Address1 = value.Address1,
                    Address2 = value.Address2,
                    City = value.City,
                    Province = value.Province,
                    PostalCode = value.PostalCode,
                    YTDSales = value.YTDSales,
                    CreditHold = value.CreditHold,
                    Notes = value.Notes,
                    IsTaxable = value.IsTaxable
                };
                OnPropertyChanged();
            }
        }

        public int Count
        {
            get
            {
                return clients.Count;
            }
        }
    }
}
