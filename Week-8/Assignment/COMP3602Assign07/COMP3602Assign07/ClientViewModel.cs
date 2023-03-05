using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3602Assign07
{
    class ClientViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public readonly decimal GstRate;
        public readonly decimal PstRate;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ClientViewModel(decimal gstRate, decimal pstRate) 
        {
            GstRate = gstRate;
            PstRate = pstRate;
            List<Client> clientsList = ClientRepository.GetCustomerLocations();
            //clients = clientsList.CreateClients();
            ClientsSource = new BindingSource();
            ClientsSource.DataSource = clientsList;
            ClientsSource.ListChanged += ProductSource__ListChanged;
        }

        private Client displayClient;
        public Client DisplayClient
        {
            get { return displayClient; }
            set
            {
                //displayClient = new Client(GstRate, PstRate) 
                //{
                /*CompanyName = value.CompanyName;
            Address1 = value.Address1;
            Address2 = value.Address2;
            City = value.City;*/
                //};
                //OnPropertyChanged();

                displayClient = new Client(GstRate, PstRate)
                {
                    CompanyName = value.CompanyName,
                    Address1 = value.Address1,
                    Address2 = value.Address2,
                    City = value.City,

            };
                OnPropertyChanged();
            }
        }

        private readonly ClientList clients;
        public BindingSource ClientsSource { get; }

        public int Count
        {
            get
            {
                return clients.Count;
            }
        }

        /*public string Totals
        {
            get
            {
                return string.Format("{0,15:N2}\r\n{1,15:N2}\r\n{2,15:N2}\r\n{3,15:N2}\r\n",
                                                   clients.TotalCost,
                                                   clients.TotalPst,
                                                   clients.TotalGst,
                                                   clients.Total);
            }
        }*/

        private void ProductSource__ListChanged(object sender, ListChangedEventArgs e)
        {
            OnPropertyChanged("Count");
            OnPropertyChanged("Totals");
        }
    }
}
