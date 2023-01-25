// Monika Szucs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab02
{
    class ConsolePrinter
    {
        // Printing out the members
        public static void PrintPeople(Member[] people)
        {
            Console.WriteLine("{0, -12} {1, -11} {2, 11} {3, 11}", "FirstName", "LastName", "AgeYears", "AgeDecades");
            Console.WriteLine(new string('-', 48));

            foreach (Member person in people)
            {
                Console.WriteLine("{0, -12} {1, -11} {2, 11} {3, 11}",
                                    person.FirstName,
                                    person.LastName,
                                    person.AgeYears,
                                    person.AgeInDecades);
            }
            Console.WriteLine("\n");
        }

        public static void PrintTitle(string line)
        {
            Console.Title = line;
        }
    }
}
