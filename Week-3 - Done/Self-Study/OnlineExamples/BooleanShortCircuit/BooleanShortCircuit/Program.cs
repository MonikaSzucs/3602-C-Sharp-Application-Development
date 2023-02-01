using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanShortCircuit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Boolean Short Circuit Demo";

            bool result;

            Console.WriteLine("true && true");
            result = returnTrue() && returnTrue();
            Console.WriteLine($"result = {result}\n");

            Console.WriteLine("false && true");
            result = returnFalse() && returnTrue();
            Console.WriteLine($"result = {result}\n");

            Console.WriteLine("false & true");
            result = returnFalse() & returnTrue();
            Console.WriteLine($"result = {result}\n");

            Console.WriteLine("true && false");
            result = returnTrue() && returnFalse();
            Console.WriteLine($"result = {result}\n");

            Console.WriteLine("false && false");
            result = returnFalse() && returnFalse();
            Console.WriteLine($"result = {result}\n\n\n");


            Console.WriteLine("true || true");
            result = returnTrue() || returnTrue();
            Console.WriteLine($"result = {result}\n");

            Console.WriteLine("false || true");
            result = returnFalse() || returnTrue();
            Console.WriteLine($"result = {result}\n");

            Console.WriteLine("true || false");
            result = returnTrue() || returnFalse();
            Console.WriteLine($"result = {result}\n");

            Console.WriteLine("true | false");
            result = returnTrue() | returnFalse();
            Console.WriteLine($"result = {result}\n");

            Console.WriteLine("false || false");
            result = returnFalse() || returnFalse();
            Console.WriteLine($"result = {result}\n");
        }

        private static bool returnTrue()
        {
            Console.WriteLine("returnTrue method called");
            return true;
        }

        private static bool returnFalse()
        {
            Console.WriteLine("returnFalse method called");
            return false;
        }
    }
}
