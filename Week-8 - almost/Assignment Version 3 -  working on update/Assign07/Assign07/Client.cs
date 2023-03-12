using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign07
{
    class Client
    {

        public Client(decimal gstRate, decimal pstRate) 
        {
            GstRate = gstRate;
            PstRate = pstRate;
        }

        public decimal PstRate { get; }
        public decimal GstRate { get; }
        public int ClientId { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public decimal YTDSales { get; set; }
        public bool CreditHold { get; set; }
        public string Notes { get; set; }
        public bool IsTaxable { get; set; }

        public string ToString()
        {
            return CompanyName + " " + Province;
        }
    }
}
