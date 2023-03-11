using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign07
{
    internal class ClientList : List<Client>
    {
        public decimal TotalYTDSales
        {
            get
            {
                decimal totalYTDSales = 0.0m;
                foreach (Client client in this)
                {
                    totalYTDSales += client.YTDSales;
                }
                return totalYTDSales;
            }
        }

        public int CountTaxableClients
        {
            get
            {
                int countTaxableClients = 0;
                foreach (Client client in this)
                {
                    if (client.IsTaxable == 'Y')
                    {
                        countTaxableClients++;
                    }
                }
                return countTaxableClients;
            }
        }

        public int CountClientsWithCreditHold
        {
            get
            {
                int countClientsWithCreditHold = 0;
                foreach (Client client in this)
                {
                    if (client.CreditHold == 'Y')
                    {
                        countClientsWithCreditHold++;
                    }
                }
                return countClientsWithCreditHold;
            }
        }
    }
}


