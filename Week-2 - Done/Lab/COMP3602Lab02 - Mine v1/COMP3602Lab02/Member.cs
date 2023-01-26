// Monika Szucs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab02
{
    class Member
    {
        private string firstName;
        private string lastName;
        private int age;

        public Member() { }

        // The constructor
        public Member(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
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

        // The age in decades
        public double AgeInDecades
        {
            get { return Age / 10.0; }
        }

        // Overriding the ToString method
        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
    }
}
