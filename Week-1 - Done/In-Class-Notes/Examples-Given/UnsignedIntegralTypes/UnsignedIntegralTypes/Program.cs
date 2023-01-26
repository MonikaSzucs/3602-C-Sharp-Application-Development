using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsignedIntegralTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Unsigned Integral Types";

            uint value = 0;
            uint result = value - 1;

            Console.WriteLine("Result: {0:N0}", result);
            Console.WriteLine("Result: {0}", result);
        }
    }
}
