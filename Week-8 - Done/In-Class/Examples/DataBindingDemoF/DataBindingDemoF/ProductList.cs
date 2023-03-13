using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
    }
}
