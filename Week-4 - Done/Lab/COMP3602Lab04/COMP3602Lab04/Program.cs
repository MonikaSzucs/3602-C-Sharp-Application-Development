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

            PersonList people = DataGenerator.GetPeople();

            people.Sort();

            try
            {
                ConsolePrinter.PrintPersonList(people);
            }
            catch (ArgumentNullException anex)
            {
                ConsolePrinter.PrintException(anex);
            }
        }
    }
}
