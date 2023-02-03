﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemoV4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Polymorphism Demo - Version 4";

            List<Employee> employees = new List<Employee>();

            employees.Add(new SalaryEmployee(1001, 3500m));
            employees.Add(new SalaryEmployee(1002, 4500m));
            employees.Add(new SalaryEmployee(1003, 3900m));

            employees.Add(new HourlyEmployee(1004, 20m, 150));
            employees.Add(new HourlyEmployee(1005, 18m, 150));

            // employees.Add(new CommissionEmployee(1006, 60000m, 0.06));

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Id: {employee.Id}  Net Pay: {employee.CalculatePay():N2}");
            }
        }
    }
}
