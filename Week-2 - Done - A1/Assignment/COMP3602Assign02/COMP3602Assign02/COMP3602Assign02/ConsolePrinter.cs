// Monika Szucs

using System;
using System.Runtime.InteropServices;

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
        public static void ShowingEnterTableTitle(string title)
        {
            Console.WriteLine(title);
        }

        public static void ShowingEnteredTableTitle(string title)
        {
            Console.WriteLine('\n');
            Console.WriteLine(title);
        }

        // creating the line
        public static void LineCreation(string line)
        {
            Console.WriteLine(line);
        }
        // The text that shows when asking the user for information
        public static void AskUserInformation(string text)
        {
            string formatStringHeading = "{0, -13}";

            Console.Write(formatStringHeading,
                            text);
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
