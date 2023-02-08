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
            string path;

            // Checking to see if a file pathway is present
            if (args.Length > 0)
            {
                path = args[0];
            }
            else
            {
                ConsolePrinter.Usage();
                return;
            }

            // Checks to see if not file exists
            if (!File.Exists(path))
            {
                ConsolePrinter.FileNotFound();
                return;
            }

            InvoiceDetails employees = ReadInvoiceFile.GetInvoices(path);

        }
    }
}
