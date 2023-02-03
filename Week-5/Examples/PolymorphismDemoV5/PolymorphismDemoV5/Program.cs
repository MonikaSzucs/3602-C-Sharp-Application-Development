using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemoV5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Polymorphism Demo - Version 5";

            List<IPayable> payables = new List<IPayable>();

            payables.Add(new SalaryEmployee(1001, 3500m));
            payables.Add(new SalaryEmployee(1002, 4500m));
            payables.Add(new SalaryEmployee(1003, 3900m));

            payables.Add(new HourlyEmployee(1004, 20m, 150));
            payables.Add(new HourlyEmployee(1005, 18m, 150));

            payables.Add(new CommissionEmployee(1006, 60000m, 0.06));

            payables.Add(new Vendor(5001, 8655m));

            foreach (IPayable payable in payables)
            {
                Console.WriteLine($"Id: {payable.Id}  Net Pay: {payable.CalculatePay():N2}");
            }
        }
    }
}
