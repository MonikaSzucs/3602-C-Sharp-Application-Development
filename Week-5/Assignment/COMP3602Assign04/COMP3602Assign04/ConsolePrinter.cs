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
        public static void PrintDottedLines(string text)
        {
            Console.WriteLine(text);
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
            //Console.WriteLine(items);

            Console.WriteLine("TEST");

            foreach (Item item in items)
            {

                string formatInvoiceItemTitles = "{0, -4} {1, -10} {2, -18}";

                // check if the item is a grocery or an appliance
                // if (item.ExpirationDate OR item.Enum)
                Console.WriteLine(
                    formatInvoiceItemTitles,
                    item.toString()
                );

                /*Console.WriteLine(formatInvoiceItemTitles,
                            item.Description,
                            item.Price,
                            item.
                            ) ;*/
            }

            // how do we call the TotalPrice function from ItemList Class?
            ItemList itemList = new ItemList(items);            
            double totalPrice = itemList.TotalPrice;

            Console.WriteLine(totalPrice);

        }
   }
}
