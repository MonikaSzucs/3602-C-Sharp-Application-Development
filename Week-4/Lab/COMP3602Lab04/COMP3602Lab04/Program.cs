// Monika Szucs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP3602 Lab04 A00878763";

            // Creating all the peoples first name, last name, and age
            PersonList person = new PersonList();

            person.Add(new Person { FirstName = "Elaine", LastName = "Benes", Age = 52 });
            person.Add(new Person { FirstName = "George", LastName = "Costanza", Age = 53 });
            person.Add(new Person { FirstName = "Larry", LastName = "Fine", Age = 61 });
            person.Add(new Person { FirstName = "Curley", LastName = "Howard", Age = 58 });
            person.Add(new Person { FirstName = "Moe", LastName = "Howard", Age = 63 });

            person.Add(new Person { FirstName = "Hank", LastName = "Kingsley", Age = 61 });
            person.Add(new Person { FirstName = "Cosmo", LastName = "Kramer", Age = 55 });
            person.Add(new Person { FirstName = "Larry", LastName = "Sanders", Age = 57 });
            person.Add(new Person { FirstName = "Jerry", LastName = "Seinfeld", Age = 55 });
            person.Add(new Person { FirstName = "Art", LastName = "Vandelay", Age = 48 });

            ConsolePrinter.PrintChartTitles();
            ConsolePrinter.PrintDottedLines();
            ConsolePrinter.PrintPersonList(person);
            ConsolePrinter.PrintDottedLines();
            ConsolePrinter.PrintTotalPersons(person.Count);
            ConsolePrinter.PrintTotalAge(person.TotalAge);
            ConsolePrinter.PrintAverageAge(person.AverageAge);
        }
    }
}
