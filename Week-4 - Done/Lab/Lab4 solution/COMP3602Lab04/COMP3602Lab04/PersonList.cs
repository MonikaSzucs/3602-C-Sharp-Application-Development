using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab04
{
    class PersonList : List<Person>
    {
        public PersonList()
        {
        }

        public PersonList(int capacity)
            : base(capacity)
        {
        }

        public int TotalAge
        {
            get
            {
                int ageSum = 0;

                foreach (Person person in this)
                {
                    ageSum += person.Age;
                }

                return ageSum;
            }
        }

        public double AverageAge
        {
            get
            {
                if (this.Count == 0)
                {
                    return 0;
                }

                return (double)this.TotalAge / this.Count;
            }
        }
    }
}
