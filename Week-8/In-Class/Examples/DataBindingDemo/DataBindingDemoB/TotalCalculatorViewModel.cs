using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingDemoB
{
    class TotalCalculatorViewModel
    {
        public AmountList Amounts { get; }

        public int TotalAmount
        {
            get
            {
                return Amounts.TotalAmount;
                //I am NOT raising an event, so the textbox doesn't know I've changed
            }
        }

        public TotalCalculatorViewModel()
        {
            Amounts = new AmountList();
        }
    }
}
