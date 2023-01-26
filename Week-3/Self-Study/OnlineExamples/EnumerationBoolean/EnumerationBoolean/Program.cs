using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationBoolean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Enumeration / Boolean Demo";

            Product item = new Product(1001, 1500m, "Super Widget");

            decimal sellPrice;

            sellPrice = item.SellVersion1(true);
            Console.WriteLine($"Sell price: {sellPrice:N2}");

            sellPrice = item.SellVersion2(ApplyDiscount.Yes);
            Console.WriteLine($"Sell price: {sellPrice:N2}");

            sellPrice = item.SellVersion1(false);
            Console.WriteLine($"Sell price: {sellPrice:N2}");

            sellPrice = item.SellVersion2(ApplyDiscount.No);
            Console.WriteLine($"Sell price: {sellPrice:N2}");
        }
    }
}
