// Monika Szucs

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

        public int CompareTo(Person other) 
        {                                   
            if (other == null)
            {
                return 1; 
            }             
            int result = this.LastName.CompareTo(other.LastName);   

            if (result == 0)                                         
            {
                result = this.FirstName.CompareTo(other.FirstName); 
            }

            return result; 
        }                   

        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}
