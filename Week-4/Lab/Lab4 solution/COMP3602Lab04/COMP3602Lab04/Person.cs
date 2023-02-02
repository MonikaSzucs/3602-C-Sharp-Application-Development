using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab04
{
    class Person : IComparable<Person> // implements IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other) // implementing IComparable<> forces 
        {                                  // the implementation of this method.
                                           //
                                           // Note that this method is expected to sort
                                           // in ascending order: A-Z or 0-9, as that is what
                                           // most people would expect it to do.
            if (other == null)
            {
                return 1; // if other object is null, this object is determined to be greater
            }             // returning here also prevents a null-reference exception accessing     
                          // other's properties below
            int result = this.LastName.CompareTo(other.LastName);   // use LastName as sort field

            if (result == 0)                                        // if Lastnames are equal   
            {
                result = this.FirstName.CompareTo(other.FirstName); // use Firstname as sort field
            }

            return result; // returns -1: this object <  other object
        }                  //          0: this object == other object 
                           //          1: this object >  other object 

        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}
