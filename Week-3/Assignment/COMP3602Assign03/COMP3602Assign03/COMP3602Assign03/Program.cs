using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace COMP3602Assign03
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsolePrinter.PrintInvoiceTitle("Invoice Listing");

            StreamReader streamReader = null;
            string path;
            string lineData;

            if (args.Length > 0)
            {
                path = args[0];
            }
            else
            {
                ConsolePrinter.Usage("Usage: COMP3602Lab03 data.txt");
                return;
            }

            if (!File.Exists(path))
            {
                ConsolePrinter.FileNotFound("\nFile not found.\n");
                return;
            }

            try
            {
                using (streamReader = new StreamReader(path))
                {

                    while ((lineData = streamReader.ReadLine()) != null)
                    {
                        char[] delimiterChars = { '|', ':' };
                        string[] invoiceDetails = Regex.Split(lineData, "\r\n|\r|\n");

                        foreach (var detail in invoiceDetails)
                        {
                            Console.WriteLine(detail);


                        }
                    }
                    /*ConsolePrinter.PrintDottedLines(new string('-', 60));
                    ConsolePrinter.LineSpace("");

                    ConsolePrinter.PrintTopOfInvoice("123");
                    ConsolePrinter.PrintTopOfInvoice("Sep 12, 2019");
                    ConsolePrinter.PrintTopOfInvoice("Sept 27, 2019");
                    ConsolePrinter.PrintTopOfInvoice("2.00% 15 days ADI");

                    ConsolePrinter.PrintDottedLines(new string('-', 60));

                    ConsolePrinter.InvoiceTitle("Qty", "SKU", "Description", "Price", "PST", "Ext");

                    ConsolePrinter.ProductLine("10", "WD2002", "2TB Hard Drive", "121.66", "N", "1,216.60");

                    ConsolePrinter.PrintDottedLines(new string('-', 60));

                    ConsolePrinter.Totals("", "Subtotal:", "", "4846.19");
                    ConsolePrinter.Totals("", "GST:", "", "242.31");

                    ConsolePrinter.PrintDottedLines(new string('-', 60));

                    ConsolePrinter.Totals("", "Total:", "", "5,088.50");
                    ConsolePrinter.LineSpace("");
                    ConsolePrinter.Totals("", "Discount:", "", "101.77");*/
                }
            }
            // this block will execute if an exception is thrown in the try block
            catch (Exception ex)
            {
                ConsolePrinter.TryError($"\n{ex.Message}\n");
            }
        }
    }
}
