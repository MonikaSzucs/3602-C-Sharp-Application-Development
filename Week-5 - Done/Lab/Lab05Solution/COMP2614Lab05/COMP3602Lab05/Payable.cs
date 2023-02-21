using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab05
{
    abstract class Payable
    {
        public int Id { get; }

        public Payable(int id)
        {
            Id = id;
        }
        public abstract decimal CalculatePay();
    }
}
