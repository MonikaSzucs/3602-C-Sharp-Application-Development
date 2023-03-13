using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Object Initializers";

            Person person =
               new Person { FirstName = "Lewis", LastName = "Black" };

            Console.WriteLine("{0}, {1}", person.LastName, person.FirstName);
            Console.WriteLine(person);
        }
    }
}
