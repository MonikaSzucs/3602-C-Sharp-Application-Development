using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProductDemoBetter
{
    class Product : IComparable<Product> // implementing interface
    {
        private int id;
        private string description;
        private decimal price;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public int CompareTo(Product other) // implementing IComparable<> forces 
        {                                   // the implementation of this method 
            if (other == null)
            {
                return 1; // if other object is null, this object is determined to be greater
            }             // returning here also prevents a null-reference exception accessing     
                          // other's properties below

            // Console.WriteLine("CompareTo Called");

            //  return this.Id.CompareTo(other.Id);

            return this.Description.CompareTo(other.Description);
        }
    }
}
