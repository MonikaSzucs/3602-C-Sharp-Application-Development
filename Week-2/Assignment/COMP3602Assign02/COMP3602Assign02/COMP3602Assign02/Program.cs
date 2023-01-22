// Monika Szucs
using System;

namespace COMP3602Assign02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP3602 - Assignment 2 - A00878763";
            Console.Write("Enter Contact Information: \n");

            Contact[] people = new Contact[3];

            string line = new string('-', 30);
            int max = 3;

            for (int i = 0; i < max; i++)
            {
                Console.WriteLine(line);
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
            
            Console.WriteLine(line);

            Console.Write("\nContacts Entered: \n");
            Console.WriteLine(line);

            foreach (Contact person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Age})\n" +
                                    $"{person.Address}\n" +
                                    $"{person.City} {person.Province}  {person.PostalCode}\n\n");
            }
        }
    }
}
