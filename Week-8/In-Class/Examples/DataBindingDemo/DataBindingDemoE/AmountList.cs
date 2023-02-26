using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataBindingDemoE
{
    class AmountList : List<int>
    {
        public int TotalAmount
        {
            get
            {
                int total = 0;
                foreach (int amount in this)
                {
                    total += amount;
                }
                return total;
            }
        }

        public decimal Average
        {
            get
            {
                if (Count == 0)
                {
                    return 0m;
                }
                else
                {
                    return (decimal)TotalAmount / Count;
                }

            }
        }

    }
}
