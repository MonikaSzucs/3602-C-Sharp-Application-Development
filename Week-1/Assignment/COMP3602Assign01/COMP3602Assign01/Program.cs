// Monika Szucs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP3602 - Assign01 - A00878763";

            string formatStringHeading = "{0, 10} {1, 9} {2, 10}";
            string formatStringIntegral = "{0, 10:N0} {1, 9:N0} {2, 10:N0}";
            int[] arr = new int[11] { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int numberTotal = 0;
            int squareTotal = 0;
            int cubeTotal = 0;

            Console.WriteLine(formatStringHeading,
                "number",
                "square",
                "cube");

            Console.WriteLine(new string('-', 32));

            for(int i = 0; i < arr.Length; i++)
            {
                int number = arr[i];
                int square = Convert.ToInt32(Math.Pow(arr[i], 2));
                int cube = Convert.ToInt32(Math.Pow(arr[i], 3));

                numberTotal += number;
                squareTotal += square;
                cubeTotal += cube;

                Console.WriteLine(formatStringIntegral,
                   number,
                   square,
                   cube);
            }

            Console.WriteLine(new string('-', 32));

            Console.WriteLine(formatStringIntegral,
                   numberTotal,
                   squareTotal,
                   cubeTotal);
        }
    }
}
