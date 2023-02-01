using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Parse Demo";

            Console.Write("Enter your age in years: ");
            string input = Console.ReadLine();

            int age = int.Parse(input);

            Console.WriteLine($"You entered: {age}");
        }
    }
}
