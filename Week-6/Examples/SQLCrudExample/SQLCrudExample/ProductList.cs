
using System.Collections.Generic;

namespace SQLCrudExample
{
    public class ProductList : List<Product>
    {
        public decimal TotalValue
        { get
            {
                decimal totalValue = 0.0m;
                foreach(Product product in this)
                {
                    totalValue += product.SellPrice * product.Quantity;
                }
                return totalValue;
            } 
        }
    }
}
