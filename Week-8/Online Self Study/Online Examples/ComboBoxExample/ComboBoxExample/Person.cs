using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxExample
{
    class Person
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }

        public string FirstName { get { return firstName; } }

        public string LastName { get { return lastName; } }

        public string FullName { get { return string.Format("{0} {1}", firstName, lastName); } }

        /// <summary>
        /// Gets the age of this person.  Maybe you don't want to calculate
        /// the age every time it is needed but if you store an age integer
        /// in addition to the birthdate then you must be careful to update
        /// the age value whenever it changes.
        /// </summary>
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int years = now.Year - birthDate.Year;

                // Has the person had a birthday this year?
                if ((now.Month < birthDate.Month)
                    || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                {
                    --years;
                }

                return years;
            }
        }

        public DateTime BirthDate { get { return birthDate; } }

        /// <summary>
        /// Gets the string representation of this object.  This is one way to 
        /// tell a ListBox control how to display this object.  It is not as 
        /// flexible as setting the ListBox's DisplayMember property (see main
        /// form) but it can act as the default value to display when 
        /// DisplayMember has not been set.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return FullName;
        }
    }
}
