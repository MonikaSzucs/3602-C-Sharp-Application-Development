// Monika Szucs

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static COMP3602Assign04.ApplianceItem;

namespace COMP3602Assign04
{
    class ReadCSVFile
    {
        // returns a list of items that could be either groceries and appliences
        public static List<Item> GetCSV(String[] args) {

            ReadCSVFile invoiceItem = new ReadCSVFile();

            //Console.WriteLine(args);

            StreamReader streamReader = null;

            string lineData;
            string numberOfLines = new string('-', 60);

            //ConsolePrinter.PrintInvoiceTitle();
            //ConsolePrinter.PrintDottedLines(numberOfLines);

            List<Item> itemList = new List<Item>();


            string path = "";

            // Checking to see if a file pathway is present
            if (args.Length > 0)
            {
                path = args[0];
            }
            else
            {
                ConsolePrinter.Usage();
                return itemList;
            }

            // Checks to see if not file exists
            if (!File.Exists(path))
            {
                ConsolePrinter.FileNotFound();
                return itemList;
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

                        string[] invoiceDetails = Regex.Split(lineData, ",");
                        //Grabs the position of the items
                        // 4L Milk,  345345,  3.87,  2019-10-14 
                        /* invoiceDetails:
                            4L Milk
                            345345
                            3.87
                            2019/10/14 
                        */
                        string name = invoiceDetails[0];
                        string sku = invoiceDetails[1];
                        float price = float.Parse(invoiceDetails[2]);

                        // we have all the data to create an item object, EXCEPT if its type of date or appliance
                        // logic to check if its date or type
                        if (invoiceDetails[3].Length == 0) {
                            GroceryItem groceryItem = new GroceryItem(
                                name,
                                price,
                                sku,
                                DateTime.MaxValue // recognize maximum datetime value as an invalid or non expiring item
                            );
                            
                            itemList.Add(groceryItem);
                        } else if (invoiceDetails[3].Contains('-')) {
                            // if the above are true, it is a grocery item

                            // formating date to en-US
                            CultureInfo us = new CultureInfo("en-US");
                            string dateFormat = "yyyy-mm-dd";
                            DateTime expirationDate = DateTime.ParseExact(invoiceDetails[3], dateFormat, us);

                            // Storing the information of the one grocery product
                            GroceryItem groceryItem = new GroceryItem(
                                name, 
                                price,
                                sku,
                                expirationDate
                            );

                            // adding the grocery items
                            itemList.Add(groceryItem);
                        } else {
                            // What appliance type it is

                            // an empty variable that will hold the type of appliance
                            ApplianceItem.ApplianceTypeEnum type = ApplianceItem.ApplianceTypeEnum.Washer;

                            // it could be a dishwasher, could be an oven, ...
                            string typeStr = invoiceDetails[3]; // "Dishwasher" or "Oven" ...

                            // Figuring out what type of appliance this is
                            if (typeStr == "Washer") 
                            {
                                type = ApplianceItem.ApplianceTypeEnum.Washer;
                            } else if (typeStr == "Dryer") 
                            {
                                type = ApplianceItem.ApplianceTypeEnum.Dryer;
                            } else if (typeStr == "Dishwasher")
                            {
                                type = ApplianceItem.ApplianceTypeEnum.Dishwasher;
                            } else if(typeStr == "Oven")
                            {
                                type = ApplianceItem.ApplianceTypeEnum.Oven;
                            } else if(typeStr == "Range")
                            {
                                type = ApplianceItem.ApplianceTypeEnum.Range;
                            } else if (typeStr == "Refrigerator")
                            {
                                type = ApplianceItem.ApplianceTypeEnum.Refrigerator;
                            } 

                            ApplianceItem appliance = new ApplianceItem(name, price, sku, type);
                            itemList.Add(appliance);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                ConsolePrinter.TryError(ex.Message);
                return itemList;
            }

            return itemList;
        }    
    }
}
