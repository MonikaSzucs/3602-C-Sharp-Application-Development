using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemoV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Polymorphism Demo - Version 2";

            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee(1001, 3500m));
            employees.Add(new Employee(1002, 4500m));
            employees.Add(new Employee(1003, 3900m));

            employees.Add(new Employee(1004, 20m, 150));
            employees.Add(new Employee(1005, 18m, 150));

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Id: {employee.Id}  Net Pay: {employee.CalculatePay():N2}");
            }
        }
    }
}
