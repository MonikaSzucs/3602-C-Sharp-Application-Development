using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemoV5
{
    interface IPayable
    {
        // has to have an ID and Calculate Pay
        int Id { get; }
        decimal CalculatePay();
    }
}
