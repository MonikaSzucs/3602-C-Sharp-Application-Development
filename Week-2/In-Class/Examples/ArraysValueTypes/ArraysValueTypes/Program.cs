using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Arrays Value Types";

            int[] numbers;          // declaration
            numbers = new int[3];   // instantiation

            numbers[0] = 329;       //
            numbers[1] = 1956;      // initialization
            numbers[2] = -392;      //

            ConsolePrinter.DisplayArrayV1(numbers);
            ConsolePrinter.DisplayArrayV2(numbers);

            // combined declaration and instantiation
            int[] someNumbersA = new int[3];

            someNumbersA[0] = 100;  //
            someNumbersA[1] = 300;  // initialization
            someNumbersA[2] = 500;  //

            // single statement declaration, instantiation 
            //  and initialization
            int[] someNumersB = new int[3] { 100, 300, 500 };

            // single statement declaration, instantiation 
            //  and initialization (more concise syntax)
            int[] someNumbersC = { 100, 300, 500 };


            double[] someDoubles = { 3.4, 5.35, 7.8 };

            string[] someStrings = { "Monday", "Tuesday", "Wednesday" };

            bool[] someBools = { true, true, false, true };
        }
    }
}
