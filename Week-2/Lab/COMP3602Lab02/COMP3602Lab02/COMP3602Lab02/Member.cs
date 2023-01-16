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

        public Member(string firstName, string lastName, int ageYears)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ageYears = ageYears;
        }

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

        public int AgeYears
        {
            get { return ageYears; }
            set { ageYears = value; }
        }

        public string AgeInDecades
        {
            get { return String.Format("{0:0.0}", ageYears / 10.0); }
        }

        public override string ToString()
        {
            return $"{firstName} {lastName} {ageYears} {AgeInDecades}";
        }
    }
}
