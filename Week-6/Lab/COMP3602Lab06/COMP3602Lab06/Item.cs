// Monika Szucs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab06
{
    public abstract class Item : IComparable<Item>
    {
        public string Description { get; set; }
        public string Sku { get; private set; }
        public decimal Price { get; set; }
        


        public Item(string description, string sku, decimal price)
        {
            Description = description;
            Price = price;
            Sku = sku;
        }

        // Organizing items by price
        public int CompareTo(Item other)
        {
            if (other == null) { 
                return 1; 
            } else {
                return this.Price.CompareTo(other.Price);
            }
        }

        public override string ToString()
        {
            return string.Format($"{Description}: {Price:N2}");
        }
    }
}
