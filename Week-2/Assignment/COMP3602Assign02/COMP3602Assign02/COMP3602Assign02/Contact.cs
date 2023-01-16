// Monika Szucs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign02
{
    class Contact
    {   
        // fields
        private string firstName;
        private string lastName;
        private string age;
        private string address;
        private string city;
        private string province;
        private string postalCode;

        // ctor
        public Contact(string firstName, string lastName, string age, string address, string city, string province, string postalCode)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.address = address;
            this.city = city;
            this.province = province;
            this.postalCode = postalCode;
        }
        // readonly Property Method
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Province
        {
            get { return province; }
            set { province = value; }
        }
        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }
    }
}
