// Monika Szucs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab02
{
    class ConsolePrinter
    {
        // Printing out the members in a chart format
        public static void PrintMembers(Member[] members)
        {
            Console.WriteLine("{0, -12} {1, -12} {2, 10} {3, 11}",
                          "FirstName",
                          "LastName",
                          "AgeYears",
                          "AgeDecades");

            Console.WriteLine(new string('-', 48));

            foreach (Member member in members)
            {
                Console.WriteLine("{0, -12} {1, -12} {2, 10:N0} {3, 11:N1}",
                              member.FirstName,
                              member.LastName,
                              member.Age,
                              member.AgeInDecades);
            }
        }
    }
}
