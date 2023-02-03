using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemoV5
{
    abstract class Employee : IPayable
    {
        public int Id { get; }

        public Employee(int id)
        {
            Id = id;
        }

        public abstract decimal CalculatePay();
    }
}
