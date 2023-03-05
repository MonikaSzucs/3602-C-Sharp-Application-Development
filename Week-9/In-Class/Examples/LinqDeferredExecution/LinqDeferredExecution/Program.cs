using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDeferredExecution
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Title = "LINQ Deferred Execution";
            
            int[] numbers = { 6, 32, 4, 17, 8, 27 };

            var query = from num in numbers
                        where (num & 1) == 0
                        select num;

            ConsolePrinter.PrintArray(query.ToArray());

            numbers[0] = 52;

            ConsolePrinter.PrintArray(query.ToArray());


            var queryMS = numbers.Where(x => (x & 1) == 0);

            numbers[1] = 31;

            ConsolePrinter.PrintArray(queryMS.ToArray());
        }
    }
}
