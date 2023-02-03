using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProductDemo
{
    class DataGenerator
    {
        public static ProductList GetProducts()
        {
            ProductList products = new ProductList();

            products.Add(new Product { Id = 100, Description = "Hard Drive 1TB", Price = 79.99m });
            products.Add(new Product { Id = 200, Description = "Video Card 1Gig", Price = 69.99m });
            products.Add(new Product { Id = 300, Description = "Keyboard", Price = 39.99m });
            products.Add(new Product { Id = 120, Description = "Hard Drive 3TB", Price = 189.99m });
            products.Add(new Product { Id = 210, Description = "Video Card 2Gig", Price = 139.99m });
            products.Add(new Product { Id = 400, Description = "Monitor 24\"", Price = 179.99m });
            products.Add(new Product { Id = 110, Description = "Hard Drive 2TB", Price = 149.99m });
            products.Add(new Product { Id = 410, Description = "Monitor 27\"", Price = 239.99m });

            return products;

        }
    }
}
