using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Dictionary Demo";

            PersonDictionary people = DataGenerator.GetPeople();

            Console.WriteLine($"{people["CK"]}\n");

            ConsolePrinter.DisplayDictionary(people);

            people.Remove("GC");

            ConsolePrinter.DisplayDictionary(people);
        }
    }
}
