using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "String Methods Demo";

            // ToUpper and ToLower
            string phrase = "How do you do?";
            Console.WriteLine(phrase);           // How do you do?
            Console.WriteLine(phrase.ToLower()); // how do you do?
            Console.WriteLine(phrase.ToUpper()); // HOW DO YOU DO?
            Console.WriteLine(phrase);           // How do you do?


            // SubString
            Console.WriteLine(phrase.Substring(0, 3));        // How
            Console.WriteLine(phrase.Substring(4, 2));        // do
            Console.WriteLine(phrase.Substring(4));           // do you do?
            Console.WriteLine(phrase.Substring(4).ToUpper()); // DO YOU DO?


            // Split
            string csvString = "one,two,three,four,five,six";

            string[] tokens = csvString.Split(',');

            foreach (string token in tokens)
            {
                Console.WriteLine(token);
            }
        }
    }
}
