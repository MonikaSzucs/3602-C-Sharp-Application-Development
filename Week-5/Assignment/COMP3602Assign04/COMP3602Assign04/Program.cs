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
            // get natural data
            // print that
            // sort that data
            // print that

            //Console.WriteLine(args[0]);
            List<Item> items = ReadCSVFile.GetCSV(args); // you're getting unsorted data = natrual order

            ConsolePrinter.PrintInvoiceData(items);

            //print the dotted line
            // sort the array
            items.Sort();
            
            // call printinvoicedata on the sorted arr
            ConsolePrinter.PrintInvoiceData(items);
        }
    }
}
