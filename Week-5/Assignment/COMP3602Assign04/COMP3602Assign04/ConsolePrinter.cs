// Monika Szucs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign04
{
    class ConsolePrinter
    {
        // Printing the dotted lines
        public static void PrintDottedLines()
        {
            string numberOfLines = new string('-', 67);
            Console.WriteLine(numberOfLines);
        }

        public static void PrintLineBreaks()
        {
            Console.WriteLine();
        }

        public static void Usage()
        {
            Console.WriteLine();
        }

        public static void TryError(string ex)
        {
            Console.WriteLine(ex);
        }

        public static void FileNotFound()
        {
            Console.WriteLine();
        }

        public static void PrintInvoiceData(List<Item> items, string choice)
        {
            if(choice == "natural")
            {
                Console.WriteLine("Natural Order:");
            } else if( choice == "sorted")
            {
                Console.WriteLine("Sorted Order:");
            }
            

            string formatInvoiceTitleRow = "{0, -40} {1, 6} {2, 2} {3, -13}";

            // check if the item is a grocery or an appliance
            // if (item.ExpirationDate OR item.Enum)
            Console.WriteLine(
                formatInvoiceTitleRow,
                "Item",
                "Price",
                "",
                "Expires"
            );

            ConsolePrinter.PrintDottedLines();

            foreach (Item item in items)
            {

                string formatInvoiceItemTitles = "{0, -40} {1, 6} {2, 2} {3, -13}";

                // check if the item is a grocery or an appliance
                // if (item.ExpirationDate OR item.Enum)

                Console.WriteLine(
                    formatInvoiceItemTitles,
                    item.toString()
                );
            }

            ConsolePrinter.PrintDottedLines();

            // how do we call the TotalPrice function from ItemList Class?
            ItemList itemList = new ItemList(items);            
            double totalPrice = itemList.TotalPrice;

            string formatInvoiceTotalRow = "{0, -38} {1, 6:N2}";

            Console.WriteLine(
                formatInvoiceTotalRow,
                "Total:",
                totalPrice
            );

            PrintLineBreaks();
            PrintLineBreaks();
        }
   }
}
