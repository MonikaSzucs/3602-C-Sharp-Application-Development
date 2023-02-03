using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign04
{
    abstract class Item
    {
        public string Description { get; set; }
        public double Price { get; set; }
        public string Sku { get; }

        public Item(string description, double price, string sku)
        {
            Description = description;
            Price = price;
            Sku = sku;
        }
        
        public int CompareTo(Item other)
        {
            return -Price.CompareTo(other.Price);
        }
    }
}
