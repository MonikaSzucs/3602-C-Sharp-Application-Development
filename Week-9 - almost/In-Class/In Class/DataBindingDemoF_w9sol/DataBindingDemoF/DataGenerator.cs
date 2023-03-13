using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingDemoF
{
    class DataGenerator
    {
        public static ProductList CreateProducts()
        {
            ProductList products = new ProductList();

            products.Add(new Product { ProductId = 1, Quantity = 10, Sku = "ABC100", Description = "Nice Widget 1", Cost = 452.55m, IsTaxable = true });
            products.Add(new Product { ProductId = 2, Quantity = 5, Sku = "ABC120", Description = "Nice Widget 2", Cost = 652.25m, IsTaxable = true });
            products.Add(new Product { ProductId = 3, Quantity = 132, Sku = "BDC140", Description = "Nice Widget 3", Cost = 1256.00m, IsTaxable = true });
            products.Add(new Product { ProductId = 4, Quantity = 62, Sku = "BDC180", Description = "Nice Widget 4", Cost = 874.25m, IsTaxable = true });
            products.Add(new Product { ProductId = 5, Quantity = 1123, Sku = "FAC205", Description = "Nice Widget 5", Cost = 559.22m, IsTaxable = true });
            products.Add(new Product { ProductId = 6, Quantity = 4, Sku = "GBS300", Description = "Nice Widget 6", Cost = 52.05m, IsTaxable = false });

            return products;
        }
    }
}
