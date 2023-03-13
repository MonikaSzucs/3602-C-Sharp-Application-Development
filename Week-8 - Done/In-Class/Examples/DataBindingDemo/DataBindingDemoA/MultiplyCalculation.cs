using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingDemoA
{
    class MultiplyCalculation 
    {
        public int OperandA { get; set; }
        public int OperandB { get; set; }
        public int Result
        {
            get { return OperandA * OperandB; }
        }
    }
}
