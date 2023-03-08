// Monika Szucs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab04
{
    class ConsolePrinter
    {
        public static void PrintPersonList(PersonList people)
        {
            if (people is null)
            {
                throw new ArgumentNullException("PersonList must not be null");
            }

            if (people.Count == 0)
            {
                Console.WriteLine("Nothing to Print");
                return;
            }

            Console.WriteLine("{0, -15} {1, -15} {2, 3}", "Last Name", "First Name", "Age");
            Console.WriteLine(new string('-', 35));

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.LastName,-15} {person.FirstName,-15} {person.Age,3}");
            }

            Console.WriteLine(new string('-', 35));
            Console.WriteLine($"Total Persons:  {people.Count:N0}");
            Console.WriteLine($"Total Age:      {people.TotalAge:N0}");
            Console.WriteLine($"Average Age:    {people.AverageAge:N2}");
        }

        public static void PrintException(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
