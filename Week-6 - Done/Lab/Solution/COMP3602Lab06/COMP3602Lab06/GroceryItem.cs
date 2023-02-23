using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab06
{
    class GroceryItem : Item
    {
        public DateTime ExpirationDate { get; private set; }

        public GroceryItem(string description, string sku, decimal price, DateTime expirationDate)
            :base(description, sku, price)
        {
            this.ExpirationDate = expirationDate;
        }

        public GroceryItem(string description, string sku, decimal price)
            :base(description, sku, price)
        {
            this.ExpirationDate = DateTime.MaxValue;
        }
    }
}
