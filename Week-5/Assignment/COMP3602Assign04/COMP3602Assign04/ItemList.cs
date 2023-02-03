using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign04
{
    class ItemList : List<Item>
    {
        public double TotalPrice 
        {
            get
            {
                return this.Sum(i => i.Price);
            }
        }
    }
}
