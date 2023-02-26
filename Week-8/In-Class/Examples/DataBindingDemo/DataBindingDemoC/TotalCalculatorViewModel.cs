using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingDemoC
{
    class TotalCalculatorViewModel
    {
        public AmountList Amounts { get; }
        public int TotalAmount
        {
            get 
            {
                return Amounts.TotalAmount;
            }
        }
        public TotalCalculatorViewModel()
        {
            Amounts = new AmountList();
        }
    }
}
