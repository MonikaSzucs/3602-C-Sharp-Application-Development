﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingDemoB
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
    }
}
