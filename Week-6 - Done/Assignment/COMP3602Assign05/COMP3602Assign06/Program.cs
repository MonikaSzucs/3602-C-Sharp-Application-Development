// Monika Szucs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP3602 Assignment05 A00878763";

            Boolean proceed = true;
            string option = "";
            
            // Ask for users input until they decide to end it
            while(proceed)
            {
                ConsolePrinter.PrintMenuOption();

                string choice = Console.ReadLine();

                // will grab the list of provinces available in database
                List<string> provencesStored = CustomerRepository.GetProvinceCodes();


                foreach (var province in provencesStored)
                {
                    // Will filter out and display only the province chosen
                    if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
                    {
                        CustomerList customerLocation = CustomerRepository.GetCustomerList(choice);
                        customerLocation.Sort();

                        ConsolePrinter.PrintCustomerListingChosen(choice, customerLocation);
                        break;
                    } else if(choice == "6")
                    {
                        proceed = false;
                        break;
                    } 
                }

                ConsolePrinter.PrintLineSpace();
            }
        }
    }
}
