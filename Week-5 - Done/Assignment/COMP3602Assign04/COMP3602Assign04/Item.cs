// Monika Szucs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign04
{
    abstract class Item : IComparable<Item>
    {
        public string Description { get; set; }
        public float Price { get; set; }
        public string Sku { get; }

        public Item(string description, float price, string sku)
        {
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
