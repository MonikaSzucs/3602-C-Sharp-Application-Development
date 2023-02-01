using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProductDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sorting Product Demo";

            ProductList products = DataGenerator.GetProducts();

            ConsolePrinter.PrintProductList(products, "Natural Order");

            // products.Sort();

            ConsolePrinter.PrintProductList(products, "Sorted Order");
        }
    }
}
