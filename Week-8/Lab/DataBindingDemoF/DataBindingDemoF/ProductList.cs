using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingDemoF
{
    class ProductList : List<Product>
    {
        public decimal TotalCost
        {
            get
            {
                decimal totalCost = 0.0m;
                foreach(Product product in this)
                {
                    totalCost += product.ExtensionCost;
                }
                return totalCost;
            }
        }

        public decimal TotalPst
        {
            get
            {
                decimal totalPst = 0.0m;
                foreach(Product product in this)
                {
                    totalPst += product.ExtensionCost * 0.07m;
                }
                return totalPst;
            }
        }

        public decimal TotalGst
        {
            get
            {
                decimal totalGst = 0.0m;
                foreach(Product product in this)
                {
                    totalGst += product.ExtensionCost * 0.05m;
                }
                return totalGst;
            }
        }

        public decimal Total
        {
            get
            {
                decimal total = 0.0m;
                total = TotalCost + TotalPst + TotalGst;

                return total;
            }
        }
    }
}
