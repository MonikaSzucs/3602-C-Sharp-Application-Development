// Monika Szucs

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab04
{
    class PersonList: List<Person>
    {
        // Calculating the total number of people
        public int TotalPersons
        {
            get
            {
                int total = 0;

                total += this.Count;

                return total;
            }
        }

        // Calculating the total age
        public int TotalAge
        {
            get
            {
                int total = 0;

                foreach (Person person in this)
                {
                    total += person.Age;
                }

                return total;
            }
        }

        // Calculating the average age
        public decimal AverageAge
        {
            get
            {
                decimal average = 0;

                if(this.Count > 0)
                {
                    average = (decimal)(Decimal.ToDouble(TotalAge) / Decimal.ToDouble(this.Count));
                }

                return average;
            }
        }
    }
}
