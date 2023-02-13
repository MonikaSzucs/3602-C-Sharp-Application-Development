using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign03
{
    class Invoices
    {
        public Invoices() { }

        public Invoices(int quantity, string sku, string description, decimal price, string pst, double ext) { 
            Quantity = quantity;
            Sku = sku;
            Description = description;
            Price = price;
            Pst = pst;
            Ext = ext;
        }

        public string InvoiceNumber { get; set; }
        public string InvoiceDate { get; set; }
        public string DiscountDate { get; set; }

        public string DiscountMonth { get; set; }

        public int DiscountDay { get; set; }
        public int DiscountYear { get; set; }
        public string Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }
        public int Terms { get; set; }
        public string ConvertedPercentage { get; set; }
        public int TermsNumberOfDays { get; set; }

        public List<Invoices> InventoryInformation { get; set; }
        public int Quantity { get; set; }
        public string Sku { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Pst { get; set; }
        public double Ext { get; set; }

        public double SubTotal { get; set; }
        public double GstPay { get; set; }

        public double PstPay { get; set; }

        public double GrandTotal { get; set; }

        public double DiscountTotal { get; set; }
    }
}
