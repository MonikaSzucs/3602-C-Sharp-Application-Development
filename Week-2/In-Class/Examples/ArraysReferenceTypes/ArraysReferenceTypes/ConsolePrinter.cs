using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysReferenceTypes
{
    class ConsolePrinter
    {
        public static void PrintPeople(Person[] people)
        {
            Console.WriteLine("{0, -15} {1, -15} {2, 6}", "FirstName", "LastName", "Age");
            Console.WriteLine(new string('-', 38));

            foreach (Person person in people)
            {
                Console.WriteLine("{0, -15} {1, -15} {2, 6}",
                                    person.FirstName,
                                    person.LastName,
                                    person.Age);
            }

            Console.WriteLine("\n");
        }
    }
}
