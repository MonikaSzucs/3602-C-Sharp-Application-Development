using System;

namespace COMP3206Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP3206 - Lab02";

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
