using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Composite Strings";

            string name = "Jennifer";
            int messageCount = 1;

            Console.WriteLine("Hello {0}, you have {1} messages.", name, messageCount);

            Console.WriteLine("Hello {0}, you have {1} message(s).", name, messageCount);

            Console.WriteLine("Hello {0}, you have {1} message{2}.",
                               name,
                               messageCount,
                               messageCount == 1 ? "" : "s");
        }
    }
}
