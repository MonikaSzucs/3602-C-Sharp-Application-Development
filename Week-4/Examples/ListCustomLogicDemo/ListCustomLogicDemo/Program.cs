using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCustomLogicDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "List Custom Logic Demo";

            decimal totalBonus = 1500m;

            EmployeeList employees = DataGenerator.GetEmployees();
            ConsolePrinter.PrintEmployeeList(employees);
            employees.GiveBonuses(totalBonus);
            Console.WriteLine($"Applying total bonus of {totalBonus:N2}\n\n");
            ConsolePrinter.PrintEmployeeList(employees);
        }
    }
}
