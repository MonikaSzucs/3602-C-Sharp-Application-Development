using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Console IO";

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("You entered {0}.", name);
        }
    }
}
