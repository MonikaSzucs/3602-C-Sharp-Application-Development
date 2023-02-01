// Monika Szucs

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
        // Printing out a message if the arguments length is 0
        public static void Usage()
        {
            Console.WriteLine("Usage: COMP3602Lab03 InvoiceData.txt");
        }

        // Printing out a message if the file cannot be found
        public static void FileNotFound()
        {
            Console.WriteLine("\nFile not found.\n");
        }

        // Printing out the error message
        public static void TryError(string ex)
        {
            Console.WriteLine($"\n{ex}\n");
        }

        // Printing the invoice title
        public static void PrintInvoiceTitle()
        {
            Console.WriteLine("Invoice Listing");
        }

        // Printing the dotted lines
        public static void PrintDottedLines(string text)
        {
            Console.WriteLine(text);
        }

        // Printing the invoice number line
        public static void PrintInvoiceNumber(string information) {
            string formatStringHeading = "{0, -15} {1, -9:N0}";

            Console.WriteLine(formatStringHeading,
                            "Invoice Number:",
                            information);
        }

        // Printing the invoice date line
        public static void PrintInvoiceDate(string monthTitle, string day, string year)
        {
            string formatStringHeading = "{0, -15} {1, -9}";

            Console.WriteLine(formatStringHeading,
                            "Invoice Date:",
                            $"{monthTitle} {day}, {year}");
        }

        // Printing the discount date line
        public static void PrintDiscountDate(string monthTitle, int discountedEndDay, int intYear)
        {
            string formatStringHeading = "{0, -15} {1, -9}";

            Console.WriteLine(formatStringHeading,
                            "Discount Date:",
                            $"{monthTitle} {discountedEndDay}, {intYear}");
        }

        // Printing the terms line
        public static void PrintTerms(string convertedPercentage, int remainder)
        {
            string formatStringHeading = "{0, -15} {1, -9}";

            Console.WriteLine(formatStringHeading,
                            "Terms",
                            $"{convertedPercentage}% {remainder} days ADI");
        }

        // Printing the title of the items that will be in the chart
        public static void InvoiceTitle()
        {
            string formatStringHeading = "{0, -4} {1, -10} {2, -18} {3, 9} {4, 4} {5, 10}";

            Console.WriteLine(formatStringHeading,
                            "Qty",
                            "SKU",
                            "Description",
                            "Price",
                            "PST",
                            "Ext");
        }

        // Printing a line space
        public static void LineSpace()
        {
            Console.WriteLine("");
        }

        // Printing the product line with correct formatting
        public static void ProductLine(
                                        string quantity,
                                        string sku,
                                        string description,
                                        string price,
                                        string pst,
                                        string ext)
        {
            string formatStringHeading = "{0, 4} {1, -10} {2, -18} {3, 9} {4, 4} {5, 10:N2}";

            Console.WriteLine(formatStringHeading,
                            quantity,
                            sku,
                            description,
                            price,
                            pst,
                            ext);
        }

        // Printing the subtotal line
        public static void SubTotal(double subTotal)
        {
            string formatStringHeading = "{0, 15} {1, -18} {2, 15} {3, 9:N2}";

            Console.WriteLine(formatStringHeading,
                                "",
                                "Subtotal",
                                "",
                                subTotal);
        }

        // Printing the GST line
        public static void Gst(double gst)
        {
            string formatStringHeading = "{0, 15} {1, -18} {2, 15} {3, 9:N2}";

            Console.WriteLine(formatStringHeading,
                                "",
                                "GST:",
                                "",
                                gst);
        }

        // Printing the PST line
        public static void Pst(double pst)
        {
            string formatStringHeading = "{0, 15} {1, -18} {2, 15} {3, 9:N2}";

            Console.WriteLine(formatStringHeading,
                                "",
                                "PST:",
                                "",
                                pst);
        }

        // Printing the total line
        public static void Total(double total)
        {
            string formatStringHeading = "{0, 15} {1, -18} {2, 15} {3, 9:N2}";

            Console.WriteLine(formatStringHeading,
                                "",
                                "Total:",
                                "",
                                total);
        }

        // Printing the discount line
        public static void Discount(double totalDiscount)
        {
            string formatStringHeading = "{0, 15} {1, -18} {2, 15} {3, 9:N2}";

            Console.WriteLine(formatStringHeading,
                                "",
                                "Discount",
                                "",
                                totalDiscount);
        }
    }
}
