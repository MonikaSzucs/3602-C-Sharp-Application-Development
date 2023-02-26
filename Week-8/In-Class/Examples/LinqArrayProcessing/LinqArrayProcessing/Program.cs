using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqArrayProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "LINQ Array Processing";

            int[] numbers = { 6, 37, 4, 17, 8, 27 };

            Console.WriteLine("{0}: {1, 4}", "Count", numbers.Count());
            Console.WriteLine("{0}: {1, 4}", "Sum  ", numbers.Sum());
            Console.WriteLine("{0}: {1, 4}", "Min  ", numbers.Min());
            Console.WriteLine("{0}: {1, 4}\n", "Max  ", numbers.Max());

            var queryQS = from num in numbers
                          where (num & 1) == 0
                          select num;

            Console.WriteLine("{0}: {1, 4}", "Count", queryQS.Count());
            Console.WriteLine("{0}: {1, 4}", "Sum  ", queryQS.Sum());
            Console.WriteLine("{0}: {1, 4}", "Min  ", queryQS.Min());
            Console.WriteLine("{0}: {1, 4}\n", "Max  ", queryQS.Max());


            var queryMS = numbers.Where(x => (x & 1) == 0);

            Console.WriteLine("{0}: {1, 4}", "Count", queryMS.Count());
            Console.WriteLine("{0}: {1, 4}", "Sum  ", queryMS.Sum());
            Console.WriteLine("{0}: {1, 4}", "Min  ", queryMS.Min());
            Console.WriteLine("{0}: {1, 4}\n", "Max  ", queryMS.Max());
        }
    }
}
