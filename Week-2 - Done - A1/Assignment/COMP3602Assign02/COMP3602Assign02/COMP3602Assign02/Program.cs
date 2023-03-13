// Monika Szucs
using System;
using System.Runtime.InteropServices;

namespace COMP3602Assign02
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsolePrinter.ProgramTitle("COMP3602 - Assignment 2 - A00878763");

            ConsolePrinter.ShowingEnterTableTitle("Enter Contact Information:");

            // Contact object
            Contact[] people = new Contact[3];

            string line = new string('-', 30);
            int max = 3;

            // Prompting to collect data for three contacts
            for (int i = 0; i < max; i++)
            {
                ConsolePrinter.LineCreation(line);

                ConsolePrinter.AskUserInformation("First Name:");
                string firstName = Console.ReadLine();

                ConsolePrinter.AskUserInformation("Last Name:");
                string lastName = Console.ReadLine();

                ConsolePrinter.AskUserInformation("Age:");
                int age = Convert.ToInt32(Console.ReadLine());

                ConsolePrinter.AskUserInformation("Address:");
                string address = Console.ReadLine();

                ConsolePrinter.AskUserInformation("City:");
                string city = Console.ReadLine();

                ConsolePrinter.AskUserInformation("Province:");
                string province = Console.ReadLine();

                ConsolePrinter.AskUserInformation("Postal Code:");
                string postalCode = Console.ReadLine();

                // Adding Contact objects to the array
                if (i == 0)
                {
                    // Creating an empty object then populating the data via properties
                    people[i] = new Contact();
                    people[i].FirstName = firstName;
                    people[i].LastName = lastName;
                    people[i].Age = age;
                    people[i].Address = address;
                    people[i].City = city;
                    people[i].Province = province;
                    people[i].PostalCode = postalCode;
                }
                else if(i == 1)
                {
                    // parameterized constructor
                    people[i] =
                       new Contact(firstName, lastName, age, address, city, province, postalCode);
                }
                else if(i == 2)
                {
                    // Object Initializer Syntax
                    // This requires an empty constructor in the Contact Class
                    people[i] =
                       new Contact { FirstName = firstName, LastName = lastName, Age = age, Address = address, City = city, Province = province, PostalCode = postalCode};
                }
            }

            #region
            #endregion
            ConsolePrinter.LineCreation(line);

            ConsolePrinter.ShowingEnteredTableTitle("Contacts Entered:");

            ConsolePrinter.LineCreation(line);

            // Outputting the contents of the Contact objects by iterating through the array
            ConsolePrinter.DisplayArray(people);
        }
    }
}
