using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Integer Arithmetic";

            int opA = 10;
            int opB = 3;
            double opC = 3.0;

            int resultA = opA / opB;     // 3
            int resultB = opA % opB;     // 1

            double resultC = opA / opB;  // 3
            double resultD = opA / opC;  // 3.33333333333333333
        }
    }
}
