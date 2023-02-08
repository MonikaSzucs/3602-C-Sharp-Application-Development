using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace COMP3602Assign03
{
    class ReadInvoiceFile
    {
        public static InvoiceDetails GetInvoices(path)
        {
            StreamReader streamReader = null;

            string lineData;
            string numberOfLines = new string('-', 60);

            ConsolePrinter.PrintInvoiceTitle();
            ConsolePrinter.PrintDottedLines(numberOfLines);


            // Try to run the code
            try
            {
                // This will read through the .txt file
                using (streamReader = new StreamReader(path))
                {

                    // This will read each line in the .txt file as long as the line is not null
                    while ((lineData = streamReader.ReadLine()) != null)
                    {
                        char[] delimiterChars = { '|', ':' };
                        string[] invoiceDetails = Regex.Split(lineData, "\r\n|\r|\n");

                        // This will grab each line in the .txt file
                        foreach (var detail in invoiceDetails)
                        {

                            ConsolePrinter.LineSpace();

                            // This will split the string based on whatever character delimination is set
                            string[] content = detail.Split(delimiterChars);

                            ConsolePrinter.PrintInvoiceNumber(content[0]);

                            // This will split the date which is in the format of YEAR/DAY/MONTH
                            string[] dateGrabbed = content[1].Split('/');

                            string year = "";
                            string month = "";
                            string day = "";
                            int incrementing = 0;

                            // This will loop through the array containing the date and assign it to the right varaible
                            foreach (var date in dateGrabbed)
                            {
                                if (incrementing == 0)
                                {
                                    year = date;
                                }
                                else if (incrementing == 1)
                                {
                                    month = date;
                                }
                                else if (incrementing == 2)
                                {
                                    day = date;
                                }

                                incrementing++;

                                // This just resets the increment back to 0
                                if (incrementing == 3)
                                {
                                    incrementing = 0;
                                }
                            }

                            // Converting the string to a int
                            int intMonth = Int32.Parse(month);

                            // This will call the MonthTitle method to grab the right month text
                            string monthTitle = MonthTitle(intMonth);

                            ConsolePrinter.PrintInvoiceDate(monthTitle, day, year);

                            // Converts the string to a int
                            int termsNumberConversion = Int32.Parse(content[2]);

                            // Grabbing the percentage value in the terms
                            double termsNumberConversionCalculation = Convert.ToDouble(termsNumberConversion / 100.0);

                            // Removes the numbers after the decminal place
                            termsNumberConversionCalculation = Math.Truncate(termsNumberConversionCalculation);

                            //Converts the percentage back to a double
                            termsNumberConversionCalculation = Convert.ToDouble(termsNumberConversionCalculation);

                            // Converts the percentage to two decminal places
                            string convertedPercentage = String.Format("{0:0.00}", termsNumberConversionCalculation);

                            // Rounds the number to two decimal places
                            double percentage = Math.Round(termsNumberConversionCalculation, 2);

                            // Calculates the remainder
                            int remainder = termsNumberConversion % 100;

                            // Converts string to int
                            int intDay = Int32.Parse(day);
                            int intYear = Int32.Parse(year);

                            // calculating the number of days in a month including leap years
                            int[] listThirtyOne = new int[] { 1, 3, 5, 7, 8, 10, 12 };
                            int[] listThirty = new int[] { 4, 6, 9, 11 };

                            int daysInMonth = 0;

                            if (listThirtyOne.Contains(intMonth))
                            {
                                daysInMonth = 31;
                            }
                            else if (listThirty.Contains(intMonth))
                            {
                                daysInMonth = 30;
                            }
                            else if (((intYear % 4 == 0) && (intYear % 100 != 0) || (intYear % 400 == 0)) && intMonth == 2)
                            {
                                daysInMonth = 29;
                            }
                            else
                            {
                                daysInMonth = 28;
                            }

                            // Calculating the discount recieved and when it will expire
                            int discountedEndDay = intDay + remainder;

                            if (discountedEndDay > daysInMonth)
                            {
                                if (intMonth == 12)
                                {
                                    intMonth = 1;
                                    intYear += 1;
                                }
                                discountedEndDay = discountedEndDay - daysInMonth;
                            }

                            monthTitle = MonthTitle(intMonth);


                            ConsolePrinter.PrintDiscountDate(monthTitle, discountedEndDay, intYear);
                            ConsolePrinter.PrintTerms(convertedPercentage, remainder);

                            ConsolePrinter.PrintDottedLines(numberOfLines);

                            ConsolePrinter.InvoiceTitle();

                            ConsolePrinter.PrintDottedLines(numberOfLines);

                            // Storing the number of items that will be sold
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

                            // Grabbing information for one product line at a time
                            foreach (var sale in selling)
                            {
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

                            ConsolePrinter.PrintDottedLines(numberOfLines);

                            ConsolePrinter.SubTotal(subTotal);

                            double gst = 0.05;
                            double gstPay = subTotal * gst;

                            ConsolePrinter.Gst(gstPay);

                            // Checking to see if any PST is needed
                            if (pstTotal > 0.0)
                            {
                                ConsolePrinter.Pst(pstTotal);
                            }

                            ConsolePrinter.PrintDottedLines(numberOfLines);

                            double total = subTotal + gstPay + pstTotal;

                            ConsolePrinter.Total(total);
                            ConsolePrinter.LineSpace();

                            double percentageDecimal = percentage / 100.0;

                            double discountTotal = Convert.ToDouble(total) * percentageDecimal;

                            ConsolePrinter.Discount(discountTotal);
                            ConsolePrinter.LineSpace();
                        }
                    }
                }
            }
            // this block will execute if an exception is thrown in the try block
            catch (Exception ex)
            {
                ConsolePrinter.TryError(ex.Message);
            }

            ConsolePrinter.LineSpace();
        }

        // Converting the number month to a String month
        static string MonthTitle(int intMonth)
        {

            string monthTitle = "";

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

            return monthTitle;
        }
    }
}
