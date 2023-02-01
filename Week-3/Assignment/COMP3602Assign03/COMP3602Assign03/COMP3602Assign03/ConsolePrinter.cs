using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace COMP3602Assign03
{
    class ConsolePrinter
    {
        public static void Usage(string usage)
        {
            Console.WriteLine(usage);
        }

        public static void FileNotFound(string error)
        {
            Console.WriteLine(error);
        }

        public static void TryError(string error)
        {
            Console.WriteLine(error);
        }

        public static void PrintInvoiceTitle(string title)
        {
            Console.WriteLine(title);
        }

        public static void PrintDottedLines(string text)
        {
            Console.WriteLine(text);
        }

        public static void PrintTopOfInvoice(string title, string information)
        {
            string formatStringHeading = "{0, -15} {1, -9}";

            Console.WriteLine(formatStringHeading,
                            title,
                            information);
        }

        public static void InvoiceTitle(string quantity,
                                        string sku,
                                        string description,
                                        string price,
                                        string pst,
                                        string ext
                                        )
        {
            //{0, 10:N0} {1, 9:N0} {2, 10:N0}
            string formatStringHeading = "{0, -2} {1, 9} {2, -18} {3, 9} {4, 9} {5, 9:N0}";

            Console.WriteLine(formatStringHeading,
                            quantity,
                            sku,
                            description,
                            price,
                            pst,
                            ext);
        }

        public static void LineSpace(string text)
        {
            Console.WriteLine(text);
        }

        public static void ProductLine(
                                        string quantity,
                                        string sku,
                                        string description,
                                        string price,
                                        string pst,
                                        string ext)
        {
            string formatStringHeading = "{0, -2} {1, 9} {2, -18} {3, 9} {4, 9} {5, 9:N0}";

            Console.WriteLine(formatStringHeading,
                            quantity,
                            sku,
                            description,
                            price,
                            pst,
                            ext);
        }

        public static void SubTotals(
                                        string title,
                                        double subTotal)
        {
            string formatStringHeading = "{0, 22} {1, 18} {2, 18} {3, 9:N0}";

            Console.WriteLine(formatStringHeading,
                                "",
                                title,
                                "",
                                subTotal);
        }
        public static void Totals(
                                    string title,
                                    double total)
        {
            string formatStringHeading = "{0, 22} {1, 18} {2, 18} {3, 9:N0}";

            Console.WriteLine(formatStringHeading,
                                "",
                                title,
                                "",
                                total);
        }

        public static void Discount(
                                    string title,
                                    double totalDiscount)
        {
            string formatStringHeading = "{0, 22} {1, 18} {2, 18} {3, 9:N0}";

            Console.WriteLine(formatStringHeading,
                                "",
                                title,
                                "",
                                totalDiscount);
        }
    }
}
