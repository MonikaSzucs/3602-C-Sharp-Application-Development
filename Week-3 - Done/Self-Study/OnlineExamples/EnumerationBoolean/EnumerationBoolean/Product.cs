using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationBoolean
{
    public enum ApplyDiscount
    {
        No
     , Yes
    }

    class Product
    {
        public const decimal DEFAULT_DISCOUNT = 0.1m;

        private int id;
        private decimal price;
        private string description;

        public Product(int id, decimal price, string description)
        {
            this.id = id;
            this.price = price;
            this.description = description;
        }

        public int Id
        {
            get { return this.id; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public decimal SellVersion1(bool applyDiscount)
        {
            decimal sellPrice;

            if (applyDiscount)
            {
                sellPrice = price - (price * DEFAULT_DISCOUNT);
            }
            else
            {
                sellPrice = price;
            }

            return sellPrice;
        }

        public decimal SellVersion2(ApplyDiscount discountMode)
        {
            decimal sellPrice;

            if (discountMode == ApplyDiscount.Yes)
            {
                sellPrice = price - (price * DEFAULT_DISCOUNT);
            }
            else
            {
                sellPrice = price;
            }

            return sellPrice;
        }
    }
}
