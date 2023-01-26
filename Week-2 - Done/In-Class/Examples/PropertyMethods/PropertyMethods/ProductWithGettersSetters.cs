using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMethods
{
    class ProductWithGettersSetters
    {
        // fields
        private int id;
        private string description;
        private decimal price;

        // ctor
        public ProductWithGettersSetters(int id, string description, decimal price)
        {
            this.id = id;
            this.description = description;
            this.price = price;
        }

        // readonly accessor
        public int GetID()
        {
            return id;
        }

        // Accessor/Mutator for Description
        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string newDescription)
        {
            description = newDescription;
        }


        // Accessor/Mutator for Price
        public decimal GetPrice()
        {
            return price;
        }

        public void SetPrice(decimal newPrice)
        {
            // optional validation code
            price = newPrice;
        }


        // ToString override
        public override string ToString()
        {
            return $"ID: {id} Desc: {description} Price: {price:N2}";
        }
    }
}
