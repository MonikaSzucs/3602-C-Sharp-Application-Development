using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypePassByValue
{
    class Program
    {
        const string labelOriginal = "Original Value:";
        const string labelInside = "Value inside PassByValue method:";
        const string labelAfter = "Value after PassByValue call:";

        static void Main(string[] args)
        {
            Console.Title = "Value Type Pass By Value Example";

            int testValue = 1750;

            Console.WriteLine($"{labelOriginal,-36} {testValue,6:N0}");

            Debug.Print($"{labelOriginal,-36} {testValue,6:N0}");

            add50PassByValue(testValue);

            Console.WriteLine($"{labelAfter,-36} {testValue,6:N0}\n\n");
        }

        private static void add50PassByValue(int input)
        {
            input += 50;
            Console.WriteLine($"{labelInside,-36} {input,6:N0}");
        }
    }
}
