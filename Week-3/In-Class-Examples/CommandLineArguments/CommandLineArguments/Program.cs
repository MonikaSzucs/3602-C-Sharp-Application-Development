using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Command Line Arguments Demo";

            if (args.Length > 0)
            {
                for (int index = 0; index < args.Length; index++)
                {
                    Console.WriteLine("args[{0}] == {1}", index, args[index]);
                }
            }
        }
    }
}
