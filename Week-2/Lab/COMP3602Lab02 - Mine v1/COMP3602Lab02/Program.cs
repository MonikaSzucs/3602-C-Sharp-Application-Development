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
            Console.Title = "COMP3206 - Lab02";

            // Instantiating 5 members using Object Initializer and adding to array
            Member[] members =
            {
              new Member { FirstName = "Tim", LastName = "Conway", Age = 61 },
              new Member { FirstName = "Larry", LastName = "Sanders", Age = 60 },
              new Member { FirstName = "Howard", LastName = "Stern", Age = 58 },
              new Member { FirstName = "Steven", LastName = "Wright", Age = 56 },
              new Member { FirstName = "Lewis", LastName = "Black", Age = 64 }
            };

            ConsolePrinter.PrintMembers(members);
        }
    }
}
