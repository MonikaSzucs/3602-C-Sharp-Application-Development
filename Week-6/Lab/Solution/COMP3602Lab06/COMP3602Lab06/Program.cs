using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP3602 Assignment 04 A00999999";

                ItemList groceries = GroceryItemRepository.GetGroceryItems();
                ConsolePrinter.PrintGroceryItems(groceries, "Natural Order:");
                groceries.Sort();
                groceries.Reverse();
                ConsolePrinter.PrintGroceryItems(groceries, "Sorted Order: [Price Descending]");
        }
    }
}
