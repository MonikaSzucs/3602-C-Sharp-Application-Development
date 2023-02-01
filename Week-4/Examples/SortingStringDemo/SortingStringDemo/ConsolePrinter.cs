using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingStringDemo
{
    class ConsolePrinter
    {
        public static void PrintStringList(StringList strings, string header)
        {
            Console.WriteLine($"{header}\n{new string('-', 13)}");

            foreach (string element in strings)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
        }
    }
}
