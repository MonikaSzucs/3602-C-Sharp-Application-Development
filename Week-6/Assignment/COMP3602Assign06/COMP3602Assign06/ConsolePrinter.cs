using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign05
{
    class ConsolePrinter
    {
        
        public static void PrintMenuOption()
        {
            Console.WriteLine("Select province filter:\n\t1) AB\n\t2) BC\n\t3) ON\n\t4) SK\n\t5) ALL\n\t6)QUIT");
        }

        public static void PrintCustomerListingChosen(string option, CustomerLocationList customerLocationList)
        {
            Console.WriteLine($"Customer listing for {option}");

            if(customerLocationList is null)
            {
                Console.WriteLine("Item List cannot be null");
                return;
            }

            if(customerLocationList.Count == 0)
            {
                Console.WriteLine("Nothing to Print");
                return;
            }

            foreach(Location customerLocation in customerLocationList)
            {
                if(customerLocation is LocationDetails)
                {
                    LocationDetails groceryDetail = customerLocation as LocationDetails;
                    Console.WriteLine($"{groceryDetail.CompanyName}");
                    Console.WriteLine($"{groceryDetail.City}");
                    Console.WriteLine($"{groceryDetail.Province}");
                    Console.WriteLine($"{groceryDetail.PostalCost}");
                    Console.WriteLine($"{groceryDetail.Hold}");
                }
            }
        }

        public static void PrintOptionError()
        {
            Console.WriteLine("Please try again. Only choose the numbers inclusive between 1 and 5");
        }

        public static void PrintLineSpace()
        {
            Console.WriteLine();
        }
        public static void PrintError(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }
    }
}
