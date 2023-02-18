using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab06
{
    abstract class Item : IComparable<Item>
    {
        public int id { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Sku { get; }

        public Item(int id, string description, float price, string sku)
        {
            id = id;
            Description = description;
            Price = price;
            Sku = sku;
        }

        public abstract string[] toString();

        public int CompareTo(Item other)
        {
            return -Price.CompareTo(other.Price);
        }
    }
}
