// Monika Szucs

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Assign04
{
    class Program
    {
        static void Main(string[] args)
        {

            // Get then print natural data
            List<Item> items = ReadCSVFile.GetCSV(args); // you're getting unsorted data = natrual order

            ConsolePrinter.PrintInvoiceData(items, "natural");

            // sort the array
            items.Sort();
            
            // call printinvoicedata on the sorted arr
            ConsolePrinter.PrintInvoiceData(items, "sorted");
        }
    }
}
