using System;


namespace COMP3206Lab02
{
    class ConsolePrinter
    {
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
