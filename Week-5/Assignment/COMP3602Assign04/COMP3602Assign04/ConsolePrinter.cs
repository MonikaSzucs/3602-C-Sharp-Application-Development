using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign04
{
    class ConsolePrinter
    {
        // Printing the Natural Order title
        public static void PrintNaturalOrderTitle()
        {
            Console.WriteLine("Natural Order:");
        }

        // Printing the Sorted Order title
        public static void PrintSortedOrderTitle()
        {
            Console.WriteLine("Sorted Order: [Price Descending]");
        }

        // Printing the dotted lines
        public static void PrintDottedLines()
        {
            string numberOfLines = new string('-', 67);
            Console.WriteLine(numberOfLines);
        }

        // Printing the invoice number line
        public static void PrintChartTitle()
        {
            string formatStringHeading = "{0, -15} {1,12} {2,2} {3,-9}";

            Console.WriteLine(formatStringHeading,
                            "Item",
                            "Price",
                            "",
                            "Expires");
        }

        public static void PrintChartDetails(string item, double price, string expires)
        {
            string formatStringHeading = "{0, -15} {1,12:C} {2,2} {3,-9}";

            Console.WriteLine(formatStringHeading,
                            item,
                            price,
                            "",
                            expires);
        }

        public static void PrintTotal(double total)
        {
            string formatStringHeading = "{0, -15} {1,12:C}";

            Console.WriteLine(formatStringHeading,
                            "Total",
                            total);
        }

        public static void PrintLineBreaks()
        {
            Console.WriteLine();
        }


        public static void PrintInvoiceTitle()
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

        public static void PrintInvoiceData(List<Item> items)
        {

            Console.WriteLine("Natural Order:");

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

            string formatInvoiceTotalRow = "{0, -40} {1, 6}";

            // check if the item is a grocery or an appliance
            // if (item.ExpirationDate OR item.Enum)
            Console.WriteLine(
                formatInvoiceTotalRow,
                "Total:",
                totalPrice
            );

            //Console.WriteLine(totalPrice);
        }
   }
}
