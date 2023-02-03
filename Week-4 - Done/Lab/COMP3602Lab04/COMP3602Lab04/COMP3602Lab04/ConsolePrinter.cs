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
        // Printing out the title in the chart
        public static void PrintChartTitles()
        {
            string formatStringHeading = "{0, -15} {1, -15} {2, -5}";

            Console.WriteLine(formatStringHeading,
                                "Last Name",
                                "First Name",
                                "Age");
        }

        // Printing out the dotted lines in the chart
        public static void PrintDottedLines()
        {
            string divider = new string('-', 35);
            Console.WriteLine(divider);
        }

        // Printing out the people in the chart by using the PersonList
        public static void PrintPersonList(PersonList persons)
        {
            string formatString = "{0, -15} {1, -15} {2, 3}";

            foreach (Person person in persons)
            {
                Console.WriteLine(formatString,
                                person.LastName,
                                person.FirstName,
                                person.Age);
            }
        }

        // Printing out the total number of persons
        public static void PrintTotalPersons(int total)
        {
            string formatString = "{0, -15} {1, -15}";

            Console.WriteLine(formatString,
                                "Total Persons:",
                                total);
        }

        // Printing out the total age
        public static void PrintTotalAge(int totalAge)
        {
            string formatString = "{0, -15} {1, -15}";

            Console.WriteLine(formatString,
                                "Total Age:",
                                totalAge);
        }

        // Printing out the average age
        public static void PrintAverageAge(decimal average)
        {
            string formatString = "{0, -15} {1, -15:N2}";

            Console.WriteLine(formatString,
                                "Average Age:",
                                average);
        }
    }
}
