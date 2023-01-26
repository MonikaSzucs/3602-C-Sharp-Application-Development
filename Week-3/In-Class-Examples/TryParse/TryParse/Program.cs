using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "TryParse Demo";

            int age;

            Console.Write("Enter your age in years: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out age))
            {
                Console.WriteLine($"You entered: {age}");
            }
            else
            {
                Console.WriteLine("Please enter a numeric value");
            }
        }
    }
}
