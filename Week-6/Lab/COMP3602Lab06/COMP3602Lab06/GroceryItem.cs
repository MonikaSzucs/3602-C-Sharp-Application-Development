using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab06
{
    class GroceryItem : Item
    {
        public DateTime ExpirationDate { get; }

        public GroceryItem(int id, string description, float price, string sku, DateTime expirationDate)
            : base(description, price, sku)
        {
            ExpirationDate = expirationDate;
        }

        public override string[] toString()
        {
            // output -> desc, price, expiry date
            string[] data = new string[4];

            data[0] = this.Description;
            data[1] = this.Price.ToString();
            data[2] = "";
            // third column could be <Never> or the date
            data[3] = this.ExpirationDate == DateTime.MaxValue ? "<Never>" : this.ExpirationDate.ToString("ddd MMM dd, yyyy");

            return data;
        }
    }
}
