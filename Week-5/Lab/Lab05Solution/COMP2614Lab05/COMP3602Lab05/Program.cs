using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Polymorphism Demo";

            List<Payable> payables = new List<Payable>();

            payables.Add(new SalaryEmployee(1001, 3500m));
            payables.Add(new SalaryEmployee(1002, 4500m));
            payables.Add(new SalaryEmployee(1003, 3900m));

            payables.Add(new HourlyEmployee(1004, 20m, 150));
            payables.Add(new HourlyEmployee(1005, 18m, 150));

            payables.Add(new CommissionEmployee(1006, 60000m, 0.06));

            payables.Add(new Vendor(5001, 8655m));

            foreach (Payable payable in payables)
            {
                Console.WriteLine($"Id: {payable.Id}  Net Pay: {payable.CalculatePay():N2}");
            }
        }
    }
}
