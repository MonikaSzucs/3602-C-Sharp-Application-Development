using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCustomLogicDemo
{
    class EmployeeList : List<Employee>
    {
        public void GiveBonuses(decimal totalBonusFund)
        {
            decimal bonus = totalBonusFund / this.Count;

            foreach (Employee employee in this)
            {
                employee.GiveBonus(bonus);
            }
        }

        public decimal TotalSalary
        {
            get
            {
                decimal total = 0;

                foreach (Employee employee in this)
                {
                    total += employee.Salary;
                }

                return total;
            }
        }

        public decimal AverageSalary
        {
            get
            {
                decimal average = 0;

                if (this.Count > 0)
                {
                    average = TotalSalary / this.Count;
                }

                return average;
            }
        }

        public decimal MinimumSalary
        {
            get
            {
                decimal salary = this[0].Salary;

                foreach (Employee employee in this)
                {
                    if (employee.Salary < salary)
                    {
                        salary = employee.Salary;
                    }
                }

                return salary;
            }
        }

        public decimal MaximumSalary
        {
            get
            {
                decimal salary = this[0].Salary;

                foreach (Employee employee in this)
                {
                    if (employee.Salary > salary)
                    {
                        salary = employee.Salary;
                    }
                }

                return salary;
            }
        }
    }
}

