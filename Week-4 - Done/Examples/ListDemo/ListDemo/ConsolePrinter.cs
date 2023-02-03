using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class ConsolePrinter
    {
        public static void ShowPeople(PersonList people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }

            Console.WriteLine();
        }
    }
}
