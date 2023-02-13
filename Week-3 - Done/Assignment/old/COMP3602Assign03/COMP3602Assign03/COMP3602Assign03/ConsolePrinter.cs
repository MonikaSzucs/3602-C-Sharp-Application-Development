// Monika Szucs

using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        // Printing a line space
        public static void LineSpace()
        {
            Console.WriteLine("");
        }

        

        public static void PrintInvoiceDate(InvoiceDetails invoiceItems)
        {
            string numberOfLines = new string('-', 60);

            ConsolePrinter.LineSpace();

            foreach (Invoices invoices in invoiceItems)
            {
                string formatStringHeading = "{0, -15} {1, -9:N0}";

                Console.WriteLine(formatStringHeading,
                            "Invoice Number:",
                            invoices.InvoiceNumber);

                string formatInvoiceDate = "{0, -15} {1, -9}";

                Console.WriteLine(formatInvoiceDate,
                            "Invoice Date:",
                            $"{invoices.Month} {invoices.Day}, {invoices.Year}");

                string formatDiscountDate = "{0, -15} {1, -9}";

                Console.WriteLine(formatDiscountDate,
                            "Discount Date:",
                            $"{invoices.DiscountMonth} {invoices.DiscountDay}, {invoices.DiscountYear}");

                string formatAdi = "{0, -15} {1, -9}";

                Console.WriteLine(formatAdi,
                            "Terms",
                            $"{invoices.ConvertedPercentage}% {invoices.TermsNumberOfDays} days ADI");

                ConsolePrinter.PrintDottedLines(numberOfLines);

                string formatInvoiceItemTitles = "{0, -4} {1, -10} {2, -18} {3, 9} {4, 4} {5, 10}";

                Console.WriteLine(formatInvoiceItemTitles,
                            "Qty",
                            "SKU",
                            "Description",
                            "Price",
                            "PST",
                            "Ext");

                ConsolePrinter.PrintDottedLines(numberOfLines);


                foreach (Invoices invoice in invoices.InventoryInformation)
                {
                    string formatInvoiceItems = "{0, 4} {1, -10} {2, -18} {3, 9} {4, 4} {5, 10:N2}";

                    Console.WriteLine(formatInvoiceItems,
                                    invoice.Quantity,
                                    invoice.Sku,
                                    invoice.Description,
                                    invoice.Price,
                                    invoice.Pst,
                                    invoice.Ext);
                }

                ConsolePrinter.PrintDottedLines(numberOfLines);

                string formatSubtotal = "{0, 15} {1, -18} {2, 15} {3, 9:N2}";

                Console.WriteLine(formatSubtotal,
                                    "",
                                    "Subtotal:",
                                    "",
                                    invoices.SubTotal);

                string formatGstPay = "{0, 15} {1, -18} {2, 15} {3, 9:N2}";

                Console.WriteLine(formatGstPay,
                                    "",
                                    "GST:",
                                    "",
                                    invoices.GstPay);

                if (invoices.PstPay > 0.0)
                {
                    string formatPstPay = "{0, 15} {1, -18} {2, 15} {3, 9:N2}";

                    Console.WriteLine(formatPstPay,
                                        "",
                                        "PST:",
                                        "",
                                        invoices.PstPay);
                }

                ConsolePrinter.PrintDottedLines(numberOfLines);


                string formatTotal = "{0, 15} {1, -18} {2, 15} {3, 9:N2}";

                Console.WriteLine(formatTotal,
                                    "",
                                    "Total:",
                                    "",
                                    invoices.GrandTotal);

                ConsolePrinter.LineSpace();


                string formatDiscountTotal = "{0, 15} {1, -18} {2, 15} {3, 9:N2}";

                Console.WriteLine(formatDiscountTotal,
                                    "",
                                    "Discount:",
                                    "",
                                    invoices.DiscountTotal
                                    );

                ConsolePrinter.LineSpace();
                ConsolePrinter.LineSpace();

            }
        }
    }
}
