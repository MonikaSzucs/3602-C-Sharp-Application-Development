using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab06
{
    class ConsolePrinter
    {
        public static void PrintGroceryItems(ItemList items, string title)
        {
            if (items is null)
            {
                Console.WriteLine("Item List cannot be null");
                return;
            }

            if (items.Count == 0)
            {
                Console.WriteLine("Nothing to Print");
                return;
            }

            Console.WriteLine(title);
            Console.WriteLine($"{"Item",-37} {"Price",8}   {"Expires"}");

            string divider = new string('-', 64);
            string dateString;
            Console.WriteLine(divider);

            foreach (Item item in items)
            {
                if (item is GroceryItem)
                {
                    GroceryItem groceryItem = item as GroceryItem;
                    dateString = groceryItem.ExpirationDate == DateTime.MaxValue ?
                                "<Never>" : groceryItem.ExpirationDate.ToString("ddd MMM d, yyyy");

                    Console.WriteLine($"{groceryItem.Description,-37} {groceryItem.Price,8:N2}   {dateString}");
                } else
                {
                    //Code for printing appliances here
                }
            }

            Console.WriteLine(divider);
            Console.WriteLine($"{"Total: ",-37} {items.TotalPrice,8:n2}\n\n");
        }
    
        public static void PrintError(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }
    }
}
