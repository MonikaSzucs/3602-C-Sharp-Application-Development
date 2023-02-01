using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingStringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sorting String Demo";

            StringList fruits = new StringList();

            fruits.Add("Orange");
            fruits.Add("Banana");
            fruits.Add("Tangerine");
            fruits.Add("Apple");
            fruits.Add("Grape");
            fruits.Add("Plum");
            fruits.Add("Cherry");
            fruits.Add("Peach");

            ConsolePrinter.PrintStringList(fruits, "Natural Order");

            fruits.Sort();

            ConsolePrinter.PrintStringList(fruits, "Sorted Order");
        }
    }
}
