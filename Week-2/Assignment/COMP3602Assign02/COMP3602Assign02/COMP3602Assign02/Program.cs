// Monika Szucs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP3602 - Assignment 2 - A00878763";

            Console.Write("Enter Contact Information: \n");

            Contact[] people = new Contact[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(new string('-', 30));
                Console.Write("First Name:\t");
                string firstName = Console.ReadLine();
                Console.Write("Last Name:\t");
                string lastName = Console.ReadLine();
                Console.Write("Age:\t\t");
                string age = Console.ReadLine();
                Console.Write("Address:\t");
                string address = Console.ReadLine();
                Console.Write("City:\t\t");
                string city = Console.ReadLine();
                Console.Write("Province:\t");
                string province = Console.ReadLine();
                Console.Write("Postal Code:\t");
                string postalCode = Console.ReadLine();

                people[i] = new Contact(firstName, lastName, age, address, city, province, postalCode);
            }
            Console.WriteLine(new string('-', 30));

            Console.Write("\nContacts Entered: \n");
            Console.WriteLine(new string('-', 30));

            foreach (Contact person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Age})\n" +
                                    $"{person.Address}\n" +
                                    $"{person.City} {person.Province}  {person.PostalCode}\n\n");
            }
        }
    }
}
