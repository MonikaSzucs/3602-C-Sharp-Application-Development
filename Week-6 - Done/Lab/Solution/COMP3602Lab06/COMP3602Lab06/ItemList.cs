using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab06
{
    class ItemList : List<Item>
    {
        public decimal TotalPrice
        {
            get
            {
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
