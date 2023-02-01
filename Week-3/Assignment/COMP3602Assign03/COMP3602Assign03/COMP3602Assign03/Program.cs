using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace COMP3602Assign03
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsolePrinter.PrintInvoiceTitle("Invoice Listing");
            ConsolePrinter.PrintDottedLines(new string('-', 60));

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
                            double termsNumberConversionCalculation = Convert.ToDouble(termsNumberConversion / 100.0);

                            termsNumberConversionCalculation = Math.Truncate(termsNumberConversionCalculation);
                            termsNumberConversionCalculation = Convert.ToDouble(termsNumberConversionCalculation);
                            string convertedPercentage = String.Format("{0:0.00}", termsNumberConversionCalculation);


                            double percentage = Math.Round(termsNumberConversionCalculation, 2);
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


                            ConsolePrinter.PrintTopOfInvoice("Terms:", $"{convertedPercentage}% {remainder} days ADI");

                            ConsolePrinter.PrintDottedLines(new string('-', 60));

                            ConsolePrinter.InvoiceTitle("Qty", "SKU", "Description", "Price", "PST", "Ext");

                            ConsolePrinter.PrintDottedLines(new string('-', 60));

                            //Console.WriteLine(content[3].GetType());
                            //Console.WriteLine(double.Parse(content[3]));
                            //double quantity = double.Parse(content[3]);
                            //double price = double.Parse(content[6]);

                            //double cost = quantity * price;

                            string[] selling = detail.Split('|');
                            selling = selling.Skip(1).ToArray();

                            int firstPosition = 3;
                            int secondPosition = 4;
                            int thirdPosition = 5;
                            int fourthPosition = 6;
                            int fifthPosition = 7;

                            double pst = 0.07;
                            double pstTotal = 0.0;

                            double subTotal = 0.0;

                            foreach (var sale in selling)
                            {
                                //Console.WriteLine(sale);
                                double quantity = double.Parse(content[firstPosition]);
                                double price = double.Parse(content[fourthPosition]);
                                double cost = quantity * price;

                                if (content[fifthPosition] == "Y")
                                {
                                    pstTotal += (quantity * price) * pst;
                                }

                                ConsolePrinter.ProductLine(content[firstPosition], content[secondPosition], content[thirdPosition], content[fourthPosition], content[fifthPosition], cost.ToString());
                                firstPosition += 5;
                                secondPosition += 5;
                                thirdPosition += 5;
                                fourthPosition += 5;
                                fifthPosition += 5;
                                subTotal += cost;
                            }

                            ConsolePrinter.PrintDottedLines(new string('-', 60));

                            ConsolePrinter.SubTotals("Subtotal:", subTotal);

                            double gst = 0.05;
                            double gstPay = subTotal * gst;
                            ConsolePrinter.SubTotals("GST:", gstPay);

                            if(pstTotal > 0.0)
                            {
                                ConsolePrinter.SubTotals("PST:", pstTotal);
                            }

                            ConsolePrinter.PrintDottedLines(new string('-', 60));

                            double total = subTotal + gstPay + pstTotal;
                            ConsolePrinter.Totals("Total:", total);
                            ConsolePrinter.LineSpace("");

                            double percentageDecimal = percentage / 100.0;

                            double discountTotal = Convert.ToDouble(total) * percentageDecimal;
                            ConsolePrinter.Discount("Discount:", discountTotal);

                            ConsolePrinter.LineSpace("");
                        }
                    }
                }
            }
            // this block will execute if an exception is thrown in the try block
            catch (Exception ex)
            {
                ConsolePrinter.TryError($"\n{ex.Message}\n");
            }

            ConsolePrinter.LineSpace("");
        }
    }
}
