using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Convert.To__ Demo";

            string input;
            int age;

            Console.Write("Enter your age in years: ");
            input = Console.ReadLine();

            age = Convert.ToInt32(input);

            Console.WriteLine($"You entered: {age}");
        }
    }
}
