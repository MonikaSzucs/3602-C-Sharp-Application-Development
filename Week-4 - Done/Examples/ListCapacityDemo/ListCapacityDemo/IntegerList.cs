using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCapacityDemo
{
    class IntegerList : List<int>
    {
        public IntegerList()
        {

        }

        public IntegerList(int capacity)
            : base(capacity)
        {

        }
    }
}
