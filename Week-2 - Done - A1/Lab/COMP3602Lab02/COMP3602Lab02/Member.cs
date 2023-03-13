using System;

namespace COMP3206Lab02
{

    class Member
    {
        private string firstName;
        private string lastName;
        private int age;

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

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // calculated property
        public double AgeInDecades
        {
            get { return Age / 10.0; }
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
    }
}
