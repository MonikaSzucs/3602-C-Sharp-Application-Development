using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class ConsolePrinter
    {
        public static void DisplayDictionary(PersonDictionary personDictionary)
        {
            foreach (KeyValuePair<string, Person> kvp in personDictionary)
            {
                Console.WriteLine($"{kvp.Key} {kvp.Value}");
            }

            Console.WriteLine();
        }
    }
}
