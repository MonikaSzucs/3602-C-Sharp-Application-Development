// Monika Szucs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP 3602 Lab06 A00878763";

            ItemList products = ProductRepository.GetProducts();
            ConsolePrinter.PrintProducts(products, "Natural Order:");
            products.Sort();
            products.Reverse();
            ConsolePrinter.PrintProducts(products, "Sorted Order: [Price Descending]");
        }
    }
}
