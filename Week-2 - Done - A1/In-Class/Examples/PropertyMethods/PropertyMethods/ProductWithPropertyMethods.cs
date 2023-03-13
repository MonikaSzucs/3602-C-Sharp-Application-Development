using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMethods
{
    class ProductWithPropertyMethods
    {
        // fields
        private int id;
        private string description;
        private decimal price;

        // ctor
        public ProductWithPropertyMethods(int id, string description, decimal price)
        {
            this.id = id;
            this.description = description;
            this.price = price;
        }

        // readonly Property Method
        public int ID
        {
            get
            {
                return id;
            }
        }

        // Property method for Description (in the acceptable compressed format)
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        // Property method for Price (in the "non-compressed" format)
        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                // optional validation code
                price = value;
            }
        }

        // ToString override
        public override string ToString()
        {
            return $"ID: {id} Desc: {description} Price: {price:N2}";
        }
    }
}
