using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullConditionalDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Null Conditional Example";

            string name = null;// = "Melissa";

            int nameLength;

            //nameLength = name.Length; // could throw an exception

            if (name != null) // null test before Length call
            {
                nameLength = name.Length;
            }
            else
            {
                nameLength = 0;
            }

            // with ? and ?? operators

            nameLength = name?.Length ?? 0;

            nameLength = name == null ? 0 : name.Length;

            string one = "One";
            string two = "Two";
            string three = "Three";

            Console.WriteLine($"Result: {one ?? two ?? three}");
            one = null;

            Console.WriteLine($"Result: {one ?? two ?? three}");
            two = null;

            Console.WriteLine($"Result: {one ?? two ?? three}");
        }
    }
}
