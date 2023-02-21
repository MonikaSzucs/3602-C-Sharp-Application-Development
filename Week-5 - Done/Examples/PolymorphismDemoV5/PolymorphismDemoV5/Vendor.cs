using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemoV5
{
    class Vendor : IPayable
    {
        public int Id { get; }
        public decimal TotalInvoices { get; }

        public Vendor(int id, decimal totalInvoices)
        {
            Id = id;
            TotalInvoices = totalInvoices;
        }

        public decimal CalculatePay()
        {
            return TotalInvoices;
        }
    }
}
