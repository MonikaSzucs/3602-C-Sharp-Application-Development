using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingIntegerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sorting Integer Demo";

            IntegerList ints = new IntegerList();

            ints.Add(123);
            ints.Add(202);
            ints.Add(786);
            ints.Add(554);
            ints.Add(327);
            ints.Add(825);
            ints.Add(986);
            ints.Add(667);

            ConsolePrinter.PrintIntegerList(ints, "Natural Order");

            Console.WriteLine($"Total:      {ints.Total,7:N0}");
            Console.WriteLine($"Even Total: {ints.EvenTotal,7:N0}");
            Console.WriteLine($"Even Count: {ints.EvenCount,7:N0}\n\n");

            ints.Sort();

            ConsolePrinter.PrintIntegerList(ints, "Sorted Order");
        }
    }
}
