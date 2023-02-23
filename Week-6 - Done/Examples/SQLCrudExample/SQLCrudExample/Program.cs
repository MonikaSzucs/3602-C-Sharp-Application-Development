using System;

namespace SQLCrudExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Product Editor";

            ProductList products = ProductRepository.GetProducts();
            products.Sort();
            ProductUI.PrintProducts(products);
            Console.ReadKey();

            Product newProduct = new Product(0, 10, "TEST", "Test Product", 149.99m);
            ProductRepository.AddProduct(newProduct);

            products = ProductRepository.GetProducts();
            products.Sort();
            ProductUI.PrintProducts(products);
            Console.ReadKey();

            Product addedProduct = products[products.Count - 1];
            addedProduct.Description = "This product was updated!";
            ProductRepository.UpdateProduct(addedProduct);

            products = ProductRepository.GetProducts();
            products.Sort();
            ProductUI.PrintProducts(products);
            Console.ReadKey();

            Product updatedProduct = products[products.Count - 1];
            ProductRepository.DeleteProduct(updatedProduct);

            products = ProductRepository.GetProducts();
            products.Sort();
            ProductUI.PrintProducts(products);
        }
    }
}
