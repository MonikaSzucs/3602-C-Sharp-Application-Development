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

        // public abstract string DateOrType();
        
        public int CompareTo(Item other)
        {
            return -Price.CompareTo(other.Price);
        }

        /*List<Integer> numbers;

        // unsorted
        { 1, 4, 3, 6, 7, 8, 2 }

        // sorted - desc order
        numbers.sort();
        { 8, 7, 6, 4, 3, 2, 1 }

        // our case - each element has name, price, type / exp date
        // unsorted - natural order
        List<Item> items;
        { 
            ( Crystal Clean Dishwasher, 800, Dishwasher ),
            ( 4L Milk, 4, 17-02-2023 ),
            ( Insignia Mini Fridge, 70, Refrigrator )
        }

        // sort - desc based on price
        // acc to c# - > item has ~ 10 bytes, address of where the item is in memory
        items.sort(); // err => idk what is items so idk how to sort

        // internal sort in c# -> can take primitive datatypes
        item1.compareTo(item2)
        milk.compareTo(Dishwasher) -> -1
        { milk, fridge, dishwasher }

        {dishwasher, fridge, milk }*/
    }
}
