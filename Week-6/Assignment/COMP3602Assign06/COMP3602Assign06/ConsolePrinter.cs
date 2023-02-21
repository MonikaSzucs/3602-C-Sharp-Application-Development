using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign05
{
    class ConsolePrinter
    {

        const int CompanyName = 40, City = 15, Province = 6, PostalCode = 13, Hold = 13;
        static readonly int totalWidth = CompanyName + City + Province + PostalCode + Hold;
        static readonly string lineBreak = new string('-', totalWidth);
        static readonly string formatTitleString = "{0,-" + CompanyName + "} {1,-" + City + "} {2,-" + Province + "} {3,-" + PostalCode + "} {4,-" + Hold + "}";
        static readonly string formatProvinceString = "{0,-" + CompanyName + "} {1,-" + City + "} {2,-" + Province + "} {3,-" + PostalCode + "} {4,-" + Hold + "}";

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

            Console.WriteLine();

            // check if the item is a grocery or an appliance
            // if (item.ExpirationDate OR item.Enum)
            Console.WriteLine(
                formatTitleString,
                "CompanyName",
                "City",
                "Prov",
                "Postal",
                "Hold"
            );

            Console.WriteLine(lineBreak);

            foreach (Location customerLocation in customerLocationList)
            {
                

                

                if (customerLocation is LocationDetails)
                {
                    LocationDetails locationDetails = customerLocation as LocationDetails;

                    Console.WriteLine(
                        formatProvinceString,
                        $"{locationDetails.CompanyName}",
                        $"{locationDetails.City}",
                        $"{locationDetails.Province}",
                        $"{locationDetails.PostalCode}",
                        $"{locationDetails.Hold}"
                    );

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
