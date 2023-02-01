using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProductDemo
{
    class ConsolePrinter
    {
        public static void PrintProductList(ProductList products, string header)
        {
            Console.WriteLine($"{header}\n{new string('-', 31)}");

            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Id,-6} {product.Description,-15} {product.Price,8:N2}");
            }

            Console.WriteLine("\n");
        }
    }
}
