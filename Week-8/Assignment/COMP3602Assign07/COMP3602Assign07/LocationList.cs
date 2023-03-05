using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign07
{
    internal class LocationList : List<Location>
    {
        public decimal TotalYTDSales
        {
            get
            {
                decimal totalYTDSales = 0.0m;
                foreach(Location location in this)
                {
                    totalYTDSales += 1;
                }
                return totalYTDSales;
            }
        }

        public int CountTaxableClients
        {
            get
            {
                int countTaxableClients = 0;
                foreach(Location location in this)
                {
                    countTaxableClients++;
                }
                return countTaxableClients;
            }
        }

        public int CountClientsWithCreditHold
        {
            get
            {
                int countClientsWithCreditHold = 0;
                foreach(Location location in this)
                {
                    countClientsWithCreditHold++;
                }
                return countClientsWithCreditHold;
            }
        }
    }
}
