using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemoV4
{
    class HourlyEmployee : Employee
    {
        public decimal Wage { get; }
        public double Hours { get; }

        public HourlyEmployee(int id, decimal wage, double hours)
            : base(id)
        {
            Wage = wage;
            Hours = hours;
        }

        public override decimal CalculatePay()
        {
            return Wage * (decimal)Hours;
        }
    }
}
