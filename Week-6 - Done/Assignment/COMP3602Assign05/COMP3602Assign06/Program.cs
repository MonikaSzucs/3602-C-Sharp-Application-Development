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

                if(choice == "1")
                {
                    option = "AB";
                } 
                else if(choice == "2")
                {
                    option = "BC";
                }
                else if(choice == "3")
                {
                    option = "ON";
                }
                else if(choice=="4")
                {
                    option = "SK";
                } 
                else if(choice == "5")
                {
                    option = "ALL";
                } 
                else if(choice == "6")
                {
                    option = "QUIT";
                }

                // Will filter out and display only the province chosen
                if(choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5") 
                {
                    List<Location> customerLocation = CustomerRepository.GetCustomerList(choice);
                    customerLocation.Sort();
                    ConsolePrinter.PrintCustomerListingChosen(option, customerLocation);
                } 
                else if(choice == "6") // will exit the program
                {
                    proceed = false;
                }
                else
                {
                    ConsolePrinter.PrintOptionError();
                }

                ConsolePrinter.PrintLineSpace();
            }
        }
    }
}
