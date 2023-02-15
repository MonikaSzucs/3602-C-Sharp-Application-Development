// Monika Szucs 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign04
{
    class ItemList : List<Item>
    {
        public ItemList(IEnumerable<Item> collection) : base(collection)
        {
        }

        public double TotalPrice 
        {
            get
            {
                // returns the total sum of prices of all the items in the list
                return this.Sum(i => i.Price);
            }
        }
    }
}
