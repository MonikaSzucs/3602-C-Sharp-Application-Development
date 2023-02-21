using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInitializers
{
    class InventoryItem : Item
    {
        public string Description { get; set; }
        public decimal Price { get; }
        
        public InventoryItem(int id, decimal price)
            : base(id)
        {
            Price = price;
        }

        public InventoryItem(int id, string description, decimal price)
            : this(id, price)
        {
            Description = description;
        }
    }
}
