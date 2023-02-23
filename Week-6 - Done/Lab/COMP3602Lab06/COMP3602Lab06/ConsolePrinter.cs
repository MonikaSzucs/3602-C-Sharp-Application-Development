// Monika Szucs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab06
{
    class ConsolePrinter
    {
        const int ProductIdExpire = 25, PriceWidth = 10, Expires = 11;
        static readonly int totalWidth = ProductIdExpire + PriceWidth + Expires + 7;
        static readonly string lineBreak = new string('-', totalWidth);
        static readonly string formatString = "{0, " + -ProductIdExpire + "} {1," + PriceWidth + ":N2} {2,-" + Expires + "}";

        private static void printHeader()
        {
            Console.WriteLine(formatString, "Item", "Price", "Expires");
            Console.WriteLine(lineBreak);
        }

        private static void printFooter(ItemList products)
        {
            Console.WriteLine(lineBreak);
            Console.WriteLine(formatString, 
                                "Total:",
                                products.TotalPrice, 
                                "");
            Console.WriteLine();
        }

        public static void PrintProducts(ItemList products, string title)
        {
            Console.WriteLine(title);
            printHeader();

            if(products is null)
            {
                Console.WriteLine("Item List cannot be null");
                return;
            }

            if(products.Count == 0)
            {
                Console.WriteLine("Nothing to print");
                return;
            }

            string dateString;

            foreach (Item product in products)
            {
                if (product is GroceryItem)
                {
                    GroceryItem groceryItem = product as GroceryItem;
                    dateString = groceryItem.ExpirationDate == DateTime.MaxValue ?
                                    "Never" : groceryItem.ExpirationDate.ToString("ddd MMM d, yyyy");

                    Console.WriteLine(formatString, product.Description, product.Price, dateString);
                }
            }
            printFooter(products);
        }

        public static void PrintError(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }
    }
}
