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
        private int ageYears;

        // The constructor
        public Member(string firstName, string lastName, int ageYears)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ageYears = ageYears;
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

        // The age in years
        public int AgeYears
        {
            get { return ageYears; }
            set { ageYears = value; }
        }

        // The age in decades
        public string AgeInDecades
        {
            get { return String.Format("{0:0.0}", ageYears / 10.0); }
        }

        // Overriding the ToString method
        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
    }
}
