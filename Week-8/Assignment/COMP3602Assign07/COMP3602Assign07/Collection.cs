using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign07
{
    class Collection
    {
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public char Province { get; set; }
        public string PostalCode { get; set; }
        public decimal YTDSales { get; set; }
        public char CreditHold { get; set; }
        public string Notes { get; set; }
        public char IsTaxable { get; set; }

        public Collection(string companyName, string address1, string address2, string city, char province, string postalCode, decimal yTDSales, char creditHold, string notes, char isTaxable)
        {
            CompanyName = companyName;
            Address1 = address1;
            Address2 = address2;
            City = city;
            Province = province;
            PostalCode = postalCode;
            YTDSales = yTDSales;
            CreditHold = creditHold;
            Notes = notes;
            IsTaxable = isTaxable;
        }
    }
}
