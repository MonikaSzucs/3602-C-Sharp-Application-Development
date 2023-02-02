using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    // This is also a data class because it is a collection of the data
    // But what we can see here it is a list of person instances
    // Why do we have to do this class?
    // This can help with specialized sorting and add functionality such as:
    // List of person class calculates the: How many people are over a certain age, average age
    // age of a person will be in the Person class (calculage age)
    class PersonList : List<Person>
    {
    }
}
