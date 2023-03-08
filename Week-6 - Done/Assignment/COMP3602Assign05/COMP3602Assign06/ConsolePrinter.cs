// Monika Szucs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
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
            Console.WriteLine("Select province filter:\n\t1) AB\n\t2) BC\n\t3) ON\n\t4) SK\n\t5) ALL\n\t6) QUIT");
        }

        public static void PrintCustomerListingChosen(string option, List<Customer> customerLocationList)
        {
            List<string> provinceList = CustomerRepository.GetProvinceCodes();
            string province = "\0";

            if(option == "1" || option == "2" || option == "3" || option == "4")
            {
                province = provinceList[int.Parse(option) - 1];
            } else
            {
                option = "all";
                province = "all";
            }

            Console.WriteLine($"Customer listing for {province}");

            if (customerLocationList is null)
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

            foreach (Customer customerLocation in customerLocationList)
            {
                // check if province of customerLocation matches what we're looking for
                if (province.ToLower() == customerLocation.Province.ToLower() || option.ToLower() == "all") {
                    Console.WriteLine(
                        formatProvinceString,
                        $"{customerLocation.CompanyName}",
                        $"{customerLocation.City}",
                        $"{customerLocation.Province}",
                        $"{customerLocation.PostalCode}",
                        $"{customerLocation.Hold}"
                   );   
                }
            }
        }

        public static void PrintOptionError()
        {
            Console.WriteLine("Please try again. Only type abbreviated province.");
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
