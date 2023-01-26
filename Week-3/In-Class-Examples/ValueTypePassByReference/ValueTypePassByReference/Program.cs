using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypePassByReference
{
    class Program
    {
        const string labelOriginal = "Original Value:";
        const string labelInside = "Value inside PassByReference method:";
        const string labelAfter = "Value after PassByReference call:";

        static void Main(string[] args)
        {
            Console.Title = "Value Type Pass By Reference Example";

            int testValue = 1750;

            Console.WriteLine($"{labelOriginal,-36} {testValue,6:N0}");

            add50PassByReference(ref testValue);

            Console.WriteLine($"{labelAfter,-36} {testValue,6:N0}\n\n");
        }

        private static void add50PassByReference(ref int input)
        {
            input += 50;
            Console.WriteLine($"{labelInside,-36} {input,6:N0}");
        }
    }
}
