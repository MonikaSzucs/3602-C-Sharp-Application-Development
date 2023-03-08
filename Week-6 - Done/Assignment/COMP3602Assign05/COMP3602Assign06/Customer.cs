using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign05
{
    class Customer : IComparable<Customer>
    {

        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public char Hold { get; set; }

        // with postal code
        public Customer(string companyName, string city, string province, string postalCode, char hold)
        {
            CompanyName = companyName;
            City = city;
            Province = province;
            PostalCode = postalCode;
            Hold = hold;
        }

        // with hold
        public Customer(string companyName, string city, string province, char hold)
        {
            CompanyName = companyName;
            City = city;
            Province = province;
            Hold = hold;
        }

        public Customer(string province)
        {
            Province = province;
        }


        // Order by company name
        public int CompareTo(Customer other)
        {
            return this.CompanyName.CompareTo(other.CompanyName);
        }
    }
}
