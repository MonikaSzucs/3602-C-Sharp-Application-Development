using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
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
                            ConsolePrinter.PrintDottedLines(new string('-', 60));
                            ConsolePrinter.LineSpace("");
                            //Console.WriteLine(detail);
                            string[] content = detail.Split(delimiterChars);

                            ConsolePrinter.PrintTopOfInvoice("Invoice Number:", content[0]);
                            

                            string[] dateGrabbed = content[1].Split('/');
                            string year = "";
                            string month = "";
                            string day = "";
                            int incrementing = 0;

                            foreach (var date in dateGrabbed)
                            {
                                if(incrementing == 0)
                                {
                                    year = date;
                                } 
                                else if(incrementing == 1)
                                {
                                    month = date;
                                }
                                else if(incrementing == 2)
                                {
                                    day = date;
                                }
                                incrementing++;

                                if(incrementing == 3)
                                {
                                    incrementing = 0;
                                }
                            }

                            int intMonth = Int32.Parse(month);
                            string monthTitle = "";

                            if(intMonth == 1)
                            {
                                monthTitle = "Jan";
                            } 
                            else if(intMonth == 2)
                            {
                                monthTitle = "Feb";
                            } 
                            else if (intMonth == 3)
                            {
                                monthTitle = "Mar";
                            }
                            else if (intMonth == 4)
                            {
                                monthTitle = "Apr";
                            }
                            else if (intMonth == 5)
                            {
                                monthTitle = "May";
                            }
                            else if (intMonth == 6)
                            {
                                monthTitle = "Jun";
                            }
                            else if (intMonth == 7)
                            {
                                monthTitle = "Jul";
                            }
                            else if (intMonth == 8)
                            {
                                monthTitle = "Aug";
                            }
                            else if (intMonth == 9)
                            {
                                monthTitle = "Sep";
                            }
                            else if (intMonth == 10)
                            {
                                monthTitle = "Oct";
                            }
                            else if (intMonth == 11)
                            {
                                monthTitle = "Nov";
                            }
                            else if (intMonth == 12)
                            {
                                monthTitle = "Dec";
                            }

                            ConsolePrinter.PrintTopOfInvoice("Invoice Date:", $"{monthTitle} {day}, {year}");


                            int termsNumberConversion = Int32.Parse(content[2]);
                            int percentage = termsNumberConversion/ 100;
                            int remainder = termsNumberConversion % 100;

                            int intDay = Int32.Parse(day);
                            int intYear = Int32.Parse(year);

                            int[] listThirtyOne = new int[] { 1, 3, 5, 7, 8, 10, 12 };
                            int[] listThirty = new int[] { 4,6,9,11 };

                            int daysInMonth = 0;

                            if(listThirtyOne.Contains(intMonth))
                            {
                                daysInMonth = 31;
                            } else if(listThirty.Contains(intMonth))
                            {
                                daysInMonth = 30;
                            } else if(((intYear % 4 == 0) && (intYear % 100 != 0) || (intYear % 400 == 0)) && intMonth == 2) {
                                daysInMonth = 29;
                            } else
                            {
                                daysInMonth = 28;
                            }

                            int discountedEndDay = intDay + remainder;

                            if(discountedEndDay > daysInMonth)
                            {
                                if(intMonth == 12)
                                {
                                    intMonth = 1;
                                    intYear += 1;
                                }
                                discountedEndDay = discountedEndDay - daysInMonth;
                            }

                            if (intMonth == 1)
                            {
                                monthTitle = "Jan";
                            }
                            else if (intMonth == 2)
                            {
                                monthTitle = "Feb";
                            }
                            else if (intMonth == 3)
                            {
                                monthTitle = "Mar";
                            }
                            else if (intMonth == 4)
                            {
                                monthTitle = "Apr";
                            }
                            else if (intMonth == 5)
                            {
                                monthTitle = "May";
                            }
                            else if (intMonth == 6)
                            {
                                monthTitle = "Jun";
                            }
                            else if (intMonth == 7)
                            {
                                monthTitle = "Jul";
                            }
                            else if (intMonth == 8)
                            {
                                monthTitle = "Aug";
                            }
                            else if (intMonth == 9)
                            {
                                monthTitle = "Sep";
                            }
                            else if (intMonth == 10)
                            {
                                monthTitle = "Oct";
                            }
                            else if (intMonth == 11)
                            {
                                monthTitle = "Nov";
                            }
                            else if (intMonth == 12)
                            {
                                monthTitle = "Dec";
                            }


                            ConsolePrinter.PrintTopOfInvoice("Discount Date:", $"{monthTitle} {discountedEndDay}, {intYear}");


                            ConsolePrinter.PrintTopOfInvoice("Terms:", $"{percentage}% {remainder} days ADI");

                            ConsolePrinter.PrintDottedLines(new string('-', 60));

                            ConsolePrinter.InvoiceTitle("Qty", "SKU", "Description", "Price", "PST", "Ext");

                            ConsolePrinter.PrintDottedLines(new string('-', 60));

                            //Console.WriteLine(content[3].GetType());
                            //Console.WriteLine(double.Parse(content[3]));
                            double quantity = double.Parse(content[3]);
                            double price = double.Parse(content[6]);

                            double cost = quantity * price;

                            string[] selling = detail.Split('|');
                            selling = selling.Skip(1).ToArray();

                            foreach (var sale in selling)
                            {
                                Console.WriteLine(sale);
                            }

                                ConsolePrinter.ProductLine(content[3], content[4], content[5], content[6], content[7], cost.ToString());
                        }
                    }
                    /*ConsolePrinter.PrintDottedLines(new string('-', 60));
                    

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
