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
        private int age;
        private string address;
        private string city;
        private string province;
        private string postalCode;

        public Contact() { }

        // constructor
        public Contact(string firstName, string lastName, int age, string address, string city, string province, string postalCode)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.address = address;
            this.city = city;
            this.province = province;
            this.postalCode = postalCode;
        }

        // The first name of the person
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        // The last name of the person
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        // The age of the person
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // The address where the person lives
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        // The city where the person lives
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        // The province where the person lives
        public string Province
        {
            get { return province; }
            set { province = value; }
        }

        // The postal code of the home
        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        // Overriding the toString method with a different format
        public override string ToString()
        {
            return string.Format($"{lastName}, {firstName}");
        }
    }
}
