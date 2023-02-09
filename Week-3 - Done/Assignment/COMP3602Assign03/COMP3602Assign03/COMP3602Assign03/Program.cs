using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP3602Assin";

            decimal totalBonus = 1500m;
            

            InvoiceDetails employees = ReadInvoiceFile.GetInvoices(args);
            ConsolePrinter.PrintInvoiceDate(employees);
        }
    }
}
