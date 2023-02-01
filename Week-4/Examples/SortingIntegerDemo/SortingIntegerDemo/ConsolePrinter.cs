using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingIntegerDemo
{
    class ConsolePrinter
    {
        public static void PrintIntegerList(IntegerList numbers, string header)
        {
            Console.WriteLine($"{header}\n{new string('-', 13)}");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
        }
    }
}
