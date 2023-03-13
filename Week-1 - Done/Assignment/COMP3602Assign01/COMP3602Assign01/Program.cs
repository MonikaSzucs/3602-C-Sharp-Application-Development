// Monika Szucs

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Writing a program to calculate the squares and cubes of the even numbers
            Console.Title = "COMP3602 - Assign01 - A00878763";

            // Writing the calculation of the squares and cubes of even numbers from 0 to 20 in a table format
            string formatStringHeading = "{0, 10} {1, 9} {2, 10}";
            string formatStringIntegral = "{0, 10:N0} {1, 9:N0} {2, 10:N0}";

            int max = 20;

            int numberTotal = 0;
            int squareTotal = 0;
            int cubeTotal = 0;

            string line = new string('-', 32);

            Console.WriteLine(formatStringHeading,
                "number",
                "square",
                "cube");

            Console.WriteLine(line);

            // Calculate the sum of each column and displaying numbers in each row as the for loop iterates
            for(int i = 0; i <= max; i+=2)
            {
                int number = i;
                int square = i;
                int cube = i;

                // Check to see if the number is divisible by two
                numberTotal += number;
                squareTotal += square * square;
                cubeTotal += cube * cube * cube;

                // Displaying the numbers in each row
                Console.WriteLine(formatStringIntegral,
                    number,
                    square * square,
                    cube * cube * cube);

                Debug.WriteLine("Debug output generated");
            }

            Console.WriteLine(line);

            // Display the sum of each column
            Console.WriteLine(formatStringIntegral,
                   numberTotal,
                   squareTotal,
                   cubeTotal);
        }
    }
}
