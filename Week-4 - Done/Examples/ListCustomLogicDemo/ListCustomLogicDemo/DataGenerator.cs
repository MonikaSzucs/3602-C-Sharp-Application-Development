using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCustomLogicDemo
{
    class DataGenerator
    {
        public static EmployeeList GetEmployees()
        {
            EmployeeList employees = new EmployeeList();

            employees.Add(new Employee { FirstName = "Vinny", LastName = "Barbarino", Salary = 3200m });
            employees.Add(new Employee { FirstName = "Arnold", LastName = "Horshack", Salary = 2900m });
            employees.Add(new Employee { FirstName = "Freddie", LastName = "Washington", Salary = 3500m });
            employees.Add(new Employee { FirstName = "Juan", LastName = "Epstein", Salary = 2900m });

            return employees;
        }
    }
}
