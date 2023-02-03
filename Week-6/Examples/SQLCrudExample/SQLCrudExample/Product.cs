
using System;

namespace SQLCrudExample
{
    public class Product : IComparable<Product>
    {
        public int ProductId { get; }
        public int Quantity { get; set; }
        public string Sku { get; set; }
        public string Description { get; set; }
        public decimal SellPrice { get; set; }

        public Product()
        {

        }

        public Product(int productId, int quantity, string sku, string description, decimal sellPrice)
        {
            ProductId = productId;
            Quantity = quantity;
            Sku = sku;
            Description = description;
            SellPrice = sellPrice;
        }

        public int CompareTo(Product other)
        {
            return ProductId.CompareTo(other.ProductId);
        }
    }
}
