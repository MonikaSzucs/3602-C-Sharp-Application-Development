using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeStringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Composite String Formatting";

            SystemUser[] users = new SystemUser[5];

            users[0] = new SystemUser("Geoff", 15.2, UserType.Administrator);
            users[1] = new SystemUser("Bridgette", 3.09, UserType.Administrator);
            users[2] = new SystemUser("Andrew", 44.45, UserType.PowerUser);
            users[3] = new SystemUser("Brenda", 1, UserType.User);
            users[4] = new SystemUser("Natalie", 0, UserType.User);

            string divider = new string('-', 40);
            Console.WriteLine("Average Logins Per Week");
            Console.WriteLine(divider);
            Console.WriteLine("{0, -10} {1, 10}  {2}", "Name", "Average", "User Type");
            Console.WriteLine(divider);

            foreach (SystemUser user in users)
            {
                Console.WriteLine("{0, -10} {1, 10}  {2}",
                                    user.Name,
                                    user.AverageLoginsPerWeek,
                                    user.Type);
            }

            Console.WriteLine();
        }
    }
}
