using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign03
{
    class InvoiceDetails : List<Invoices>
    {
        public double TotalCost
        {
            get
            {
                double total = 0;

                foreach (Invoices invoice in this)
                {
                    total += invoice.Ext;
                }

                return total;
            }
        }
        public decimal TotalProductCost
        {
            get
            {
                decimal totalOneProduct = 0;

                if(this.Count> 0)
                {
                    //totalOneProduct = Invoice;
                }

                return totalOneProduct;
            }
        }

        public List<Invoices> AllInvoices { 
            get
            {
                return this;
            } 
        }
    }
}
