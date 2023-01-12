using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorPrecedence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Operator Precedence";

            int firstResult = 1 + 2 * 3;
            int secondResult = (1 + 2) * 3;

            Console.WriteLine("1 + 2 * 3   = {0}", firstResult);
            Console.WriteLine("(1 + 2) * 3 = {0}", secondResult);
        }
    }
}
