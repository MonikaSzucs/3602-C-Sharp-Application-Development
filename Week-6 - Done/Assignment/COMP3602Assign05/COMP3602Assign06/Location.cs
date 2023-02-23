// Monika Szucs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign05
{
    public class Location: IComparable<Location>
    {
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public char Hold { get; set; }

        // with postal code
        public Location(string companyName, string city, string province, string postalCode, char hold)
        {
            CompanyName = companyName;
            City = city;
            Province = province;
            PostalCode = postalCode;
            Hold = hold;
        }

        // with hold
        public Location(string companyName, string city, string province, char hold)
        {
            CompanyName = companyName;
            City = city;
            Province = province;
            Hold = hold;
        }

        // Order by company name
        public int CompareTo(Location other)
        {
            return this.CompanyName.CompareTo(other.CompanyName);
        }
    }
}
