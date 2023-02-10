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
            ItemList items = (ItemList)ReadCSVFile.GetCSV(args);
            Console.WriteLine(items);


            
            
            /*string path;
            string lineData;
            string numberOfLines = new string('-', 60);

            ConsolePrinter.PrintNaturalOrderTitle();
            ConsolePrinter.PrintChartTitle();
            ConsolePrinter.PrintDottedLines(numberOfLines);
            ConsolePrinter.PrintChartDetails("4L Milk", 3.87, "Mon Oct 14, 2019");
            ConsolePrinter.PrintDottedLines(numberOfLines);
            ConsolePrinter.PrintTotal(123);

            ConsolePrinter.PrintLineBreaks();
            ConsolePrinter.PrintLineBreaks();

            ConsolePrinter.PrintSortedOrderTitle();
            ConsolePrinter.PrintChartTitle();
            ConsolePrinter.PrintDottedLines(numberOfLines);
            ConsolePrinter.PrintChartDetails("4L Milk", 3.87, "Mon Oct 14, 2019");
            ConsolePrinter.PrintDottedLines(numberOfLines);
            ConsolePrinter.PrintTotal(123);

            if(args.Length < 1)
            {
                Console.WriteLine("ERROR: Missing Argument");
                return;
            }

            string filePath = args[0];

            if(!File.Exists(filePath)) {
                Console.WriteLine("ERROR: File not found");
            }*/
        }
    }
}
