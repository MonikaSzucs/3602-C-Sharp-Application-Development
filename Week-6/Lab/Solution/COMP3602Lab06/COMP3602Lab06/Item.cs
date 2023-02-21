using System;
using System.Collections.Generic;
using System.Text;

namespace COMP3602Lab06
{
    public abstract class Item : IComparable<Item>
    {
        public string Description { get; set; }
        public string Sku { get; private set; }
        public decimal Price { get; private set; }

        public Item(string description, string sku, decimal price)
        {
            this.Description = description;
            this.Sku = sku;
            this.Price = price;
        }


        public int CompareTo(Item other) 
        {                                   
            if (other == null)
            {
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
