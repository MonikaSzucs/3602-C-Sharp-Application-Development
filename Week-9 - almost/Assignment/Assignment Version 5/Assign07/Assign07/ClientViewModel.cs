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
    public class ClientViewModel : INotifyPropertyChanged
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
            //Console.WriteLine(clients.ToString());
            ClientSource = new BindingSource();
            ClientSource.DataSource = clients;
            ClientSource.ListChanged += ClientSource_ListChanged;
            DisplayClient = new Client(GstRate, PstRate);
        }

        private void ClientSource_ListChanged(Object sender, ListChangedEventArgs e)
        {
            OnPropertyChanged("CountTotalTaxableClients");
            OnPropertyChanged("labelCountTotalCreditHold");
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
                    ClientId = value.ClientId,
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

        public string Totals
        {
            get
            {
                return string.Format("{0,15:N2}\r\n{1,15:N2}\r\n{2,15:N2}\r\n{3,-15:N2}\r\n",
                                        clients.TotalYTDSales,
                                        clients.TotalPst,
                                        clients.TotalGst,
                                        clients.Total);
            }
        }

        public int CountTotalClients
        {
            get
            {
                int count = 0;
                foreach(var client in clients)
                {
                    count++;
                }
                return count;
            }
        }

        public int CountTotalTaxableClients
        {
            get
            {
                int count = 0;
                foreach (var client in clients)
                {
                    if(client.IsTaxable == true)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public int CountTotalCreditHold
        {
            get
            {
                int count = 0;
                foreach(var client in clients)
                {
                    if(client.CreditHold == true)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}
