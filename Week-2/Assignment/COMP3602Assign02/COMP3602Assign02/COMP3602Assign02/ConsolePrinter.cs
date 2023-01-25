// Monika Szucs

using System;

namespace COMP3602Assign02
{
    class ConsolePrinter
    {
        // Creating the terminal title
        public static void ProgramTitle(string title)
        {
            Console.Title = title;
        }

        // creating the table title
        public static void TableTitle(string title)
        {
            Console.Write(title);
        }

        // creating the line
        public static void LineCreation(string line)
        {
            Console.WriteLine(line);
        }
        // The text that shows when asking the user for information
        public static void AskUserInformation(string text)
        {
            Console.Write(text);
        }

        // Outputting the contents of the Contact objects by iterating through the array
        public static void DisplayArray(Contact[] people)
        {
            foreach (Contact person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Age})\n" +
                                    $"{person.Address}\n" +
                                    $"{person.City} {person.Province}  {person.PostalCode}\n\n");
            }
        }
    }
}
