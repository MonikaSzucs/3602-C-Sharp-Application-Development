using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemoV3
{
    class Employee
    {
        public int Id { get; }

        public Employee(int id)
        {
            Id = id;
        }

        // The calculation is different in each class so you want both classes hourly and salary
        // are different thats why you use virtual
        public virtual decimal CalculatePay()
        {
            return 0m;
        }
    } 
}
