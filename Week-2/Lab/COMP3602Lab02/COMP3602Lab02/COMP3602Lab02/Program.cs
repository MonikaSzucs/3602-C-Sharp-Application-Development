// Monika Szucs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP3602Lab02";

            Member[] person = new Member[5];

            person[0] = new Member("Tim", "Conway", 61);
            person[1] = new Member("Larry", "Sanders", 60);
            person[2] = new Member("Howard", "Stern", 58);
            person[3] = new Member("Steven", "Wright", 56);
            person[4] = new Member("Lewis", "Black", 64);

            /*// get/set method calling code
            Console.WriteLine(productA.GetPrice());
            productA.SetPrice(400.00m);
            Console.WriteLine(productA.GetPrice());
            */

            ConsolePrinter.PrintPeople(person);
        }
    }
}
