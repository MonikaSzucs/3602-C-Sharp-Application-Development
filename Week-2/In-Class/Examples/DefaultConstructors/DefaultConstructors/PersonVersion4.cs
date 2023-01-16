using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultConstructors
{
    class PersonVersion4
    {
        const string DefaultFirstName = "";      // unnecessary code
        const string DefaultLastName = "";       // unnecessary code
        const string DefaultEmail = "";          // unnecessary code
        const int DefaultAge = 0;                // unnecessary code

        private string firstName;
        private string lastName;
        private string email;
        private int age;

        public PersonVersion4()                  // unnecessary code
        {                                        // unnecessary code
            FirstName = DefaultFirstName;        // unnecessary code
            LastName = DefaultLastName;          // unnecessary code
            Email = DefaultEmail;                // unnecessary code
            Age = DefaultAge;                    // unnecessary code
        }                                        // unnecessary code

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

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}",
                            firstName,
                            lastName,
                            email,
                            age);
        }
    }
}
