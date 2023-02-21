using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemoV2
{
    public enum EmployeeType
    {
        Salary,
        Hourly
    }
    class Employee
    {
        public EmployeeType Type { get; }
        public int Id { get; }
        public decimal Salary { get; }
        public decimal Wage { get; }
        public double Hours { get; }

        public Employee(int id, decimal salary)
        {
            Type = EmployeeType.Salary;
            Id = id;
            Salary = salary;
        }

        public Employee(int id, decimal wage, double hours)
        {
            Type = EmployeeType.Hourly;
            Id = id;
            Wage = wage;
            Hours = hours;
        }

        public decimal CalculatePay()
        {
            decimal netPay = 0m;

            if (Type == EmployeeType.Salary)
            {
                netPay = Salary;
            }
            else if (Type == EmployeeType.Hourly)
            {
                netPay = Wage * (decimal)Hours;
            }
            else
            {
                // throw exception - unknown employee type
            }

            return netPay;
        }
    }
}
