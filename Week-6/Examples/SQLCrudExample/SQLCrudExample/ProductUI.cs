using System;
using Microsoft.Data.SqlClient;

namespace SQLCrudExample
{
    class ProductUI
    {
        const int ProductIdWidth = 4, QtyWidth = 7, SkuWidth = 11, PriceWidth = 11, DescriptionWidth = 60;
        static readonly int totalWidth = ProductIdWidth+ QtyWidth + SkuWidth + PriceWidth + DescriptionWidth;
        static readonly string lineBreak = new string('-', totalWidth);
        static readonly string forrmatString = "{0, " + ProductIdWidth + "} {1," + QtyWidth + ":N0} {2,-" + SkuWidth + "} {3," + PriceWidth + ":N2} {4,-" + DescriptionWidth + "}";

        public static void PrintError(string message)
        {
            Console.WriteLine($"Error occurred: {message}.");
        }
        private static void printHeader()
        {
            Console.WriteLine(forrmatString, "PID", "Qty", "SKU", "Price", "Description");
            Console.WriteLine(lineBreak);
        }
        private static void printFooter(ProductList products)
        {
            Console.WriteLine(lineBreak);
            Console.WriteLine($"Total value for these products: {products.TotalValue:N2}\r\n\r\n");
        }
        public static void PrintProducts(ProductList products)
        {
            printHeader();
            foreach (Product product in products)
            {
                printProductInList(product);
            }
            printFooter(products);
        }

        private static void printProductInList(Product product)
        {
            Console.WriteLine(forrmatString, product.ProductId, product.Quantity, product.Sku, product.SellPrice, product.Description);
        }
    }
}
