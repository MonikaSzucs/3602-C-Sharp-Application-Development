using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign04
{
    class ItemList : List<Item>
    {
        //private List<Item> dataMember;

        public ItemList(IEnumerable<Item> collection) : base(collection)
        {
        }

        // using double here since max price is 999,999.99 which is supported by float
        // but 999,999.99 * size_of_list could cause a bit overflow in float...
        // quesiton: should we be worried about list of items causing a bit overflow in float datapoint?
            // because lets say we have multiple list items with max price, float would only be able to hold so many...  3.4 × 10^38
        // No - float
        // yes - double
       
        public double TotalPrice 
        {
            get
            {
                // returns the total sum of prices of all the items in the list
                return this.Sum(i => i.Price);

                // double sum;
                // foreach (var val in this) {
                //     sum += item.Price;
                // }
                // return sum;
            }
        }

        /*public List<Item> AllItems
        {
            get
            {
                return this;
            }
        }*/
    }
}
