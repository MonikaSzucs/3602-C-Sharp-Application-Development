using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab05
{
    class Vendor : Payable
    {
        public decimal TotalInvoices { get; }

        public Vendor(int id, decimal totalInvoices)
            : base(id)
        {
            TotalInvoices = totalInvoices;
        }
        public override decimal CalculatePay()
        {
            return TotalInvoices;
        }
    }
}
