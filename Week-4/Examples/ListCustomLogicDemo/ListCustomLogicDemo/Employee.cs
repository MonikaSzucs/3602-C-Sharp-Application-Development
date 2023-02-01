using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCustomLogicDemo
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public void GiveBonus(decimal bonus)
        {
            Salary += bonus;
        }
    }
}
