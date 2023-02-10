using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign04
{
    class ReadCSVFile
    {
        // returns a list of items that could be either groceries and appliences
        public static List<Item> GetCSV(String[] args) {

            ReadCSVFile invoiceItem = new ReadCSVFile();

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

            String[] lines = gettingCSVDate();
            foreach (String line in lines) {
                // parsing

                /* look at the 4th column of input -> either format 2019-10-14 OR Washer
                    to check if this is grocery item or a appliance
                    check if 4th column contains '-'
                        if yes - its a datetime
                        if no - its an appliance
                */

                if (line[4] is type string) { //cheching the datatype of column 4
                    // then define a new appliance item
                } else {
                    // this is datetime
                    // parse this to datetime
                    // then define a new grocery item
                }
            }

            // adding grocery item to the list
            itemList.Add(gItem);
            itemList.Add(aItem);
            
            return itemList;
        }    
    }
}
