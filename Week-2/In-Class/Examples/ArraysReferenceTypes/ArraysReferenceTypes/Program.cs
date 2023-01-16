using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Arrays Reference Types";

            // combined declaration and instantiation
            Person[] contacts = new Person[3];

            // initialization
            contacts[0] = new Person("Larry", "Fine", 48);
            contacts[1] = new Person("Curly", "Howard", 47);
            contacts[2] = new Person("Moe", "Howard", 53);

            ConsolePrinter.PrintPeople(contacts);

            // single statement declaration, instantiation
            //  and initialization
            Person[] people =
            {
              new Person("Larry", "Fine", 48),
              new Person("Curly", "Howard", 47),
              new Person("Moe", "Howard", 53)
            };

            ConsolePrinter.PrintPeople(people);
        }
    }
}
