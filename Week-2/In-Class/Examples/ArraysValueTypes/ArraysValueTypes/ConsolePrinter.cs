using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysValueTypes
{
    class ConsolePrinter
    {
        public static void DisplayArrayV1(int[] numbers)
        {
            // using the for loop
            for (int counter = 0; counter < numbers.Length; counter++)
            {
                Console.WriteLine("Value: {0:N0}", numbers[counter]);
            }

            Console.WriteLine("\n");
        }

        public static void DisplayArrayV2(int[] numbers)
        {
            // using the foreach loop - much more convenient
            foreach (int number in numbers)
            {
                Console.WriteLine("Value: {0:N0}", number);
            }

            Console.WriteLine("\n");
        }
    }
}
