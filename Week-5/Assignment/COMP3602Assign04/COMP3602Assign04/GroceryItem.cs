using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign04
{
    class GroceryItem : Item
    {
        public DateTime ExpirationDate { get; }

        public GroceryItem(string description, double price, string sku, DateTime expirationDate)
            : base(description, price, sku)
        {
            ExpirationDate= expirationDate;
        }
    }
}
