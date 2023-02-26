using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingDemoF
{
    class Product
    {
        public decimal PstRate { get; }
        public decimal GstRate { get; }
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Cost { get; set; }
        public decimal SellPrice { get; set; }
        public decimal ExtensionPrice { get; set; }
        public bool IsTaxable { get; set; }

        public decimal ExtensionCost
        {
            get
            {
                return Cost * 1;
            }
        }
        public Product(decimal pstRate, decimal gstRate)
        {
            PstRate = pstRate;
            GstRate = gstRate;
        }
    }
}
