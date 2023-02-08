using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign03
{
    class Invoices
    {
        public string Quantity { get; set; }
        public string Sku { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Pst { get; set; }
        public decimal Ext { get; set; }
    }
}
