using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDeferredExecution
{
    class ConsolePrinter
    {
        public static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
        }
    }
}
