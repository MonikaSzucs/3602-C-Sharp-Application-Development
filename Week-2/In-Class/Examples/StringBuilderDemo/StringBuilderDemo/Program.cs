using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "StringBuilder Demo";

            string longLabel = string.Empty;
            int repetitions = 50000;

            Console.WriteLine("Press Enter to Start String Concatenation Test");
            Console.ReadLine();

            for (int count = 0; count < repetitions; count++)
            {
                longLabel += "text content ";
            }

            Console.WriteLine(longLabel);

            Console.WriteLine("\nPress Enter to Start StringBuilder Test");
            Console.ReadLine();

            // prevents abusing of heap. This preallocates space for your string and allows you to concatenate.
            // The append allows you to add at the end without creating another string on the heap.
            StringBuilder sb = new StringBuilder(1000000);

            for (int count = 0; count < repetitions; count++)
            {
                sb.Append("text content ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
