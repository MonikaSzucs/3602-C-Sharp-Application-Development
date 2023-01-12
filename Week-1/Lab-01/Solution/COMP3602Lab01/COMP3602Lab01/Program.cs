using System;

namespace COMP3602Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP2614 - Lab01 - A00123456";

            const string Password = "ma5_t3r";

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your password: ");
            string passwordInput = Console.ReadLine();

            if (passwordInput.ToLower().Trim() == Password)
            {
                Console.WriteLine("\nHello {0}, and welcome.", name);
            }
            else
            {
                Console.WriteLine("\nAuthentication Error.");
            }
        }
    }
}
