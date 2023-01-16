using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysReferenceTypes
{
    class Person
    {
        // Automatic Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // default ctor
        public Person()
        {
            // no code
        }

        // parameterized ctor
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
