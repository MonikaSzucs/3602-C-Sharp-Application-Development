// Monika Szucs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab04
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // Orders based on last name 
        public int CompareTo(Person other) // implementing IComparable<> forces 
        {                                   // the implementation of this method 
            if (other == null)
            {
                return 1; // if other object is null, this object is determined to be greater
            }             // returning here also prevents a null-reference exception accessing     
                          // other's properties below


            //  return this.LastName.CompareTo(other.LastName);

            return this.LastName.CompareTo(other.LastName);
        }
    }
}
