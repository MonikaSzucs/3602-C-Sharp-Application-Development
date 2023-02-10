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
        public static InvoiceDetails GetInvoices(String[] args)
        {

            InvoiceDetails invoiceItem = new InvoiceDetails();

            StreamReader streamReader = null;

            string lineData;
            string numberOfLines = new string('-', 60);

            ConsolePrinter.PrintInvoiceTitle();
            ConsolePrinter.PrintDottedLines(numberOfLines);



            string path = "";

            // Checking to see if a file pathway is present
            if (args.Length > 0)
            {
                path = args[0];
            }
            else
            {
                ConsolePrinter.Usage();
                //return ;
            }

            // Checks to see if not file exists
            if (!File.Exists(path))
            {
                ConsolePrinter.FileNotFound();
                //return;
            }

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

                            // This will split the string based on whatever character delimination is set
                            string[] content = detail.Split(delimiterChars);

                            string invoiceNumber = content[0];

                            // This will split the date which is in the format of YEAR/DAY/MONTH
                            string[] dateGrabbed = content[1].Split('/');

                            string year = "";
                            string month = "";
                            string day = "";
                            int incrementing = 0;

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
                            int invoiceIntMonth = Int32.Parse(month);
                            int invoiceIntDay = Int32.Parse(day);
                            int invoiceIntYear = Int32.Parse(year);
                            // This will call the MonthTitle method to grab the right month text
                            string monthTitle = MonthTitle(invoiceIntMonth);



                            int termsNumberConversion = Int32.Parse(content[2]);

                            // Grabbing the percentage value in the terms
                            double termsNumberConversionCalculation = Convert.ToDouble(termsNumberConversion / 100.0);

                            // Removes the numbers after the decminal place
                            termsNumberConversionCalculation = Math.Truncate(termsNumberConversionCalculation);

                            //Converts the percentage back to a double
                            termsNumberConversionCalculation = Convert.ToDouble(termsNumberConversionCalculation);

                            // Converts the percentage to two decminal places
                            string convertedPercentage = String.Format("{0:0.00}", termsNumberConversionCalculation);

                            //Console.WriteLine(convertedPercentage);




                            // Rounds the number to two decimal places
                            double percentage = Math.Round(termsNumberConversionCalculation, 2);

                            // Calculates the remainder
                            int remainder = termsNumberConversion % 100;


                            // Converts string to int
                            string discountedMonth = "";
                            int discountIntDay = Int32.Parse(day);
                            int discountIntYear = Int32.Parse(year);

                            // calculating the number of days in a month including leap years
                            int[] listThirtyOne = new int[] { 1, 3, 5, 7, 8, 10, 12 };
                            int[] listThirty = new int[] { 4, 6, 9, 11 };

                            int daysInMonth = 0;

                            if (listThirtyOne.Contains(invoiceIntMonth))
                            {
                                daysInMonth = 31;
                            }
                            else if (listThirty.Contains(invoiceIntMonth))
                            {
                                daysInMonth = 30;
                            }
                            else if (((discountIntYear % 4 == 0) && (discountIntYear % 100 != 0) || (discountIntYear % 400 == 0)) && invoiceIntMonth == 2)
                            {
                                daysInMonth = 29;
                            }
                            else
                            {
                                daysInMonth = 28;
                            }

                            // Calculating the discount recieved and when it will expire
                            int discountedEndDay = discountIntDay + remainder;

                            if (discountedEndDay > daysInMonth)
                            {
                                if (invoiceIntMonth == 12)
                                {
                                    invoiceIntMonth = 1;
                                    discountIntYear += 1;
                                }
                                discountedEndDay = discountedEndDay - daysInMonth;
                            }

                            discountedMonth = MonthTitle(invoiceIntMonth);






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
                            int arrayNumberCount = 0;

                            List<Invoices> myList = new List<Invoices>();

                            // Grabbing information for one product line at a time
                            foreach (var sale in selling)
                            {
                                arrayNumberCount += 6;

                                double quantity = double.Parse(content[firstPosition]);
                                double price = double.Parse(content[fourthPosition]);
                                double cost = quantity * price;

                                if (content[fifthPosition] == "Y")
                                {
                                    pstTotal += (quantity * price) * pst;
                                }

                                int counter = 0;


                                myList.Add(new Invoices(int.Parse(content[firstPosition]), content[secondPosition], content[thirdPosition], decimal.Parse(content[fourthPosition]), content[fifthPosition], cost ));
                                //myList.Add(inv);
                                firstPosition += 5;
                                secondPosition += 5;
                                thirdPosition += 5;
                                fourthPosition += 5;
                                fifthPosition += 5;
                                subTotal += cost;
                            }

                            double gst = 0.05;
                            double gstPay = subTotal * gst;

                            double total = subTotal + gstPay + pstTotal;

                            double percentageDecimal = percentage / 100.0;

                            double discountTotal = Convert.ToDouble(total) * percentageDecimal;

                            invoiceItem.Add(new Invoices {
                                InvoiceNumber = invoiceNumber,
                                Month = monthTitle,
                                Day = invoiceIntDay,
                                Year = invoiceIntYear,
                                DiscountMonth = discountedMonth,
                                DiscountDay = discountedEndDay,
                                DiscountYear = discountIntYear,
                                Terms = termsNumberConversion,
                                ConvertedPercentage = convertedPercentage,
                                TermsNumberOfDays = remainder,
                                InventoryInformation = myList,
                                SubTotal = subTotal,
                                GstPay = gstPay,
                                PstPay = pstTotal,
                                GrandTotal = total,
                                DiscountTotal = discountTotal
                            }); 

                        }
                    }
                }
                return invoiceItem;
            }
            // this block will execute if an exception is thrown in the try block
            catch (Exception ex)
            {
                ConsolePrinter.TryError(ex.Message);
                return invoiceItem;
            }
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
