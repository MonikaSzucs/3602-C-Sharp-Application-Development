using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Extension Methods Demo";

            Console.Write("Enter a phrase: ");
            string phrase = Console.ReadLine();

            Console.WriteLine("\n{0}: {1}", "ToUpper     ", phrase.ToUpper());
            Console.WriteLine("{0}: {1}", "ToLower     ", phrase.ToLower());

            Console.WriteLine("{0}: {1}", "ToProper (S)", StringUtilities.ToProper(phrase));

            Console.WriteLine("{0}: {1}", "ToProper (E)", phrase.ToProper());
        }
    }
}
