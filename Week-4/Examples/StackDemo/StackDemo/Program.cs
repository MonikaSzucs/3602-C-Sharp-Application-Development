using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Stack Demo";

            StringStack stack = new StringStack();

            stack.Push("One");
            stack.Push("Two");
            stack.Push("Three");

            while (stack.Count > 0) // always check stack for content
            {                       // prior to calling Pop
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
