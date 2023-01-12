using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * name             Monika Szucs
 * studentNumber    A00878763
 * date             January 11, 2023
 */
namespace COMP3602Lab01
{
    internal class COMP3602Lab01
    {

        static void Main(string[] args)
        {
            string firstName;
            string password;
            const String loginPassword = "ma5_t3r";

            Console.Write("Please Enter Your First Name: ");
            firstName = Console.ReadLine();


            Console.Write("Please Enter Your Password: ");
            password = Console.ReadLine().ToLower().TrimStart().TrimEnd();

            if (password == loginPassword)
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
