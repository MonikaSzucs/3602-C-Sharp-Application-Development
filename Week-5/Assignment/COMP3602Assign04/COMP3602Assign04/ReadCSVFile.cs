﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace COMP3602Assign04
{
    class ReadCSVFile
    {
        // returns a list of items that could be either groceries and appliences
        public static List<Item> GetCSV(String[] args) {

            ReadCSVFile invoiceItem = new ReadCSVFile();

            Console.WriteLine(args);

            StreamReader streamReader = null;

            string lineData;
            string numberOfLines = new string('-', 60);

            ConsolePrinter.PrintInvoiceTitle();
            ConsolePrinter.PrintDottedLines(numberOfLines);

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

                        string[] invoiceDetails = Regex.Split(lineData, ",");

                        //Console.WriteLine(invoiceDetails);
                        Console.WriteLine(invoiceDetails.Length);

                        int number = 1;
                        string firstItem = "";
                        float secondItem = 0;
                        string thirdItem = "";
                        string fourthItem = "";

                        foreach (var detail in invoiceDetails)
                        {
                            Console.WriteLine(detail);
                            //Console.WriteLine(detail.Length);
                            //if(detail)

                            if(number == 1)
                            {
                                firstItem = detail;
                            } 
                            else if(number == 2)
                            {
                                secondItem = float.Parse(detail);
                            } 
                            else if(number == 3)
                            {
                                thirdItem = detail;
                            } 
                            else if(number == 4)
                            {
                                fourthItem = detail;

                                if(detail.Length == 0 || detail.Contains('-'))
                                {
                                    Console.WriteLine("Has empty column or -");

                                    GroceryItem gItem = new GroceryItem(
                                        firstItem,
                                        secondItem,
                                        thirdItem,
                                        DateTime.Now
                                    );

                                    itemList.Add(gItem);
                                    
                                } else
                                {
                                    ApplianceItem aItem = new ApplianceItem(
                                        firstItem,
                                        secondItem,
                                        thirdItem,
                                        ApplianceItem.ApplianceTypeEnum.Oven  // example oven appliance item
                                    );

                                    itemList.Add(aItem);
                                }
                            }



                            number++;
                        }

                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                ConsolePrinter.TryError(ex.Message);
                // return ""
            }



            /*
                                    //build up a list of items containing grocereies and applicance
                                    List<Item> itemList = new List<Item>();

                        // get the data from the csv
                        // parse the data
                            // check if the item is a groceryItem or a applianceItem
                            // set appliance type accordinly

                        // for an example
                        GroceryItem gItem = new GroceryItem(
                            "bogus desc",
                            999.99f,
                            "123456",
                            DateTime.Now
                        );

                        ApplianceItem aItem = new ApplianceItem(
                            "bogus desc",
                            9123.99f,
                            "99585",
                            ApplianceItem.ApplianceTypeEnum.Oven  // example oven appliance item
                        );

                        // while parsing, check if there's a match for any of the ApplianceTypeEnums
                            // if yes - then use ApplianceItem.ApplianceTypeEnum.  <-- define the type that matched

                        //String[] lines = gettingCSVDate();
                        //foreach (String line in lines) {
                            // parsing

                            *//* look at the 4th column of input -> either format 2019-10-14 OR Washer
                                to check if this is grocery item or a appliance
                                check if 4th column contains '-'
                                    if yes - its a datetime
                                    if no - its an appliance
                            *//*

                            //if (line[4] is type string) { //cheching the datatype of column 4
                                // then define a new appliance item
                            //} else {
                                // this is datetime
                                // parse this to datetime
                                // then define a new grocery item
                            //}
                        //}

                        // adding grocery item to the list
                        itemList.Add(gItem);
                        itemList.Add(aItem);

                        return itemList;*/
            return itemList;
        }    
    }
}
