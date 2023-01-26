using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckedUnchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Checked / Unchecked Demo";

            short adder = 5000;
            // adder += 10000;   // uncomment this line and rerun - observe behavior

            short shortVal = 20000;
            Console.WriteLine($"Value is: {shortVal:N0}");

            shortVal += adder;
            Console.WriteLine($"Value is: {shortVal:N0}");

            checked
            {
                shortVal = 20000;
                Console.WriteLine($"Value is: {shortVal:N0}");

                shortVal += adder;
                Console.WriteLine($"Value is: {shortVal:N0}");
            }
        }
    }
}
