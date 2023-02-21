// Monika Szucs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab06
{
    class ItemList: List<Item>
    {
        // Calculating the total Price
        public decimal TotalPrice
        {
            get
            {
                // returns the total sum of prices of all the items in the list
                decimal total = 0.0m;

                foreach (Item item in this)
                {
                    total += item.Price;
                }
                return total;
            }
        }
    }
}
