using System;

namespace COMP3602Lab01Version2
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
            string passwordInput = readPassword();

            if (passwordInput.ToLower().Trim() == Password)
            {
                Console.WriteLine("\n\nHello {0}, and welcome.", name);
            }
            else
            {
                Console.WriteLine("\n\nAuthentication Error.");
            }
        }

        private static string readPassword()
        {
            const string Mask = "*";
            string password = "";
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);
                Console.Write(Mask);
                password += keyInfo.KeyChar.ToString();

            } while (keyInfo.Key != ConsoleKey.Enter);

            return password;
        }
    }
}
