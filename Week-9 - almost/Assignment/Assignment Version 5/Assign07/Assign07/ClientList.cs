using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Assign07
{
    class ClientList: List<Client>
    {

        //clients.TotalCost,
        //clients.TotalPst,
        //clients.TotalGst,
        //clients.Total

        public decimal TotalYTDSales
        {
            get
            {
                decimal totalYTDSales = 0.0m;
                foreach(Client client in this)
                {
                    totalYTDSales += client.YTDSales;
                }
                return totalYTDSales;
            }
        }

        public decimal TotalPst
        {
            get
            {
                decimal totalPst = 0.0m;
                
                foreach(Client client in this)
                {
                    totalPst += client.IsTaxable ? client.YTDSales * client.PstRate : 0.0m; 
                }
                return totalPst;
            }
        }

        public decimal TotalGst
        {
            get
            {
                decimal totalGst = 0.0m;

                foreach(Client client in this)
                {
                    totalGst += client.IsTaxable ? client.YTDSales * client.GstRate : 0.0m;
                }
                return totalGst;
            }
        }

        public decimal Total
        {
            get
            {
                return TotalYTDSales + TotalPst + TotalGst;
            }
        }

        public int CountTaxableClients
        {
            get
            {
                int count = 0;

                foreach (Client client in this)
                {
                    if (client.IsTaxable == true)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}
