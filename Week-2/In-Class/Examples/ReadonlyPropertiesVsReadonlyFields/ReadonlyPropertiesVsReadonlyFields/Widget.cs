using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadonlyPropertiesVsReadonlyFields
{
    class Widget
    {
        private readonly int id;
        private string sku;
        private decimal price;

        public Widget(int id)
        {
            this.id = id;
        }

        private void updateId()
        {
            //  id = 100;
        }

        private void updateSku()
        {
            sku = "ABC100";
        }

        public int Id
        {
            get { return id; }
        }

        public string Sku
        {
            get { return sku; }
            //   set { sku = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
