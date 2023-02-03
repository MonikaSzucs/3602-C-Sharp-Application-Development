using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCustomLogicDemo
{
    class ConsolePrinter
    {
        public static void PrintEmployeeList(EmployeeList employees)
        {
            string divider = new string('-', 36);
            Console.WriteLine($"{"FirstName", -12} {"LastName", -12} {"Salary", 10:N2}");
            Console.WriteLine(divider);

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.FirstName, -12} {employee.LastName, -12} {employee.Salary, 10:N2}");
            }

            Console.WriteLine(divider);
            Console.WriteLine($"{"", -12} {"Total:", -12} {employees.TotalSalary, 10:N2}");
            Console.WriteLine($"{"", -12} {"Average:", -12} {employees.AverageSalary, 10:N2}");
            Console.WriteLine($"{"", -12} {"Minimum:", -12} {employees.MinimumSalary, 10:N2}");
            Console.WriteLine($"{"", -12} {"Maximum:", -12} {employees.MaximumSalary, 10:N2}\n\n");
        }
    }
}
