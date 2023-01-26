// Monika Szucs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            const String LoginPassword = "ma5_t3r";
            string firstName;
            string password;

            Console.Write("Please Enter Your First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Please Enter Your Password: ");
            password = Console.ReadLine().ToLower().TrimStart().TrimEnd();

            if (password == LoginPassword)
            {
                Console.WriteLine("Hello {0}, and welcome.", firstName);
            }
            else
            {
                Console.Write("The password is incorrect.");
            }
        }
    }
}
