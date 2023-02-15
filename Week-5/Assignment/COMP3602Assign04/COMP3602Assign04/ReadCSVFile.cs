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

                            CultureInfo us = new CultureInfo("en-US");
                            string dateFormat = "yyyy-mm-dd";
                            // Console.WriteLine("GOING TO CONERT DATE TIME " + invoiceDetails[3]);
                            DateTime expirationDate = DateTime.ParseExact(invoiceDetails[3], dateFormat, us);

                            // Console.WriteLine("CONVERTED DATETIME");
                            // DateTime expirationDate = DateTime.Parse(invoiceDetails[3]);

                            GroceryItem groceryItem = new GroceryItem(
                                name, 
                                price,
                                sku,
                                expirationDate
                            );

                            itemList.Add(groceryItem);
                        } else {
                            // What appliance type it is
                            // ApplianceTypeEnum applianceType = ApplianceItem.(invoiceDetails[3]);

                            // an empty variable that will hold the type of appliance
                            // ApplianceItem.ApplianceTypeEnum type; 
                            ApplianceItem.ApplianceTypeEnum type = ApplianceItem.ApplianceTypeEnum.Washer;

                            // it could be a dishwasher, could be an over, ...
                            string typeStr = invoiceDetails[3]; // "Dishwasher" or "Oven" ...

                            // we gotta figure out what type of appliance this is
                            // Dishwasher,
                                //Oven,
                                            //Range,
                                            //Refrigerator
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


                            // xyz() --> this means that xyz is a function or a method
                            // xyz   --> this means that xyz is an OBJECT or a VARIABLE
                        }

/**
ApplianceItem.ApplianceTypeEnum

                    C#
                    |
                   Item
                  /    \
        GroceryItem:Type
 | |
 M F

Q ->  why not Item.GroceryItem? 
GrocerItem is A TYPE of Item, it is NOT A Item
Since item is abstract

 Student Monika = new Student (
    F,
    "Monika",
    1234
 )

 Monika.Gender == F ==> should return True
Gender.F = F

Item item = {
    Description,
    Price,
    SKU
}

Item aeroplane = { "Aeroplane", "5M", "0900" }
aeroplane.desc = Aeroplane
aeroplane.price = 5,000,000

GroceryItem gItem = {
    description,
    price,
    Sku,
    expiration date
}

GroceryItem milk = { "4L Milk", 4, 5677, 02-17-2023 }
milk.des = 4L Milk
milk.expDate = 4L Milk

*/

                    }
                }
            }
            catch (Exception ex)
            {
                ConsolePrinter.TryError(ex.Message);
                return itemList;
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

            //Item[] itemArr = itemList.ToArray();

            //ItemList itemL = new ItemList(itemList);

            return itemList;
        }    
    }
}
