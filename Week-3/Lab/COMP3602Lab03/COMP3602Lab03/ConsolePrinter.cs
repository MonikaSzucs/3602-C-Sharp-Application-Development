using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab03
{
    class ConsolePrinter
    {
        public static void PrintChartLine()
        {
            Console.WriteLine(new string ('-', 30));
        }

        public static void PrintChartTitle()
        {
            string formatStringHeading = "{0, -13} {1, -9} {2, 6}";
            
            Console.WriteLine(formatStringHeading,
                            "First Name",
                            "Last Name",
                            "Age");
        }

        public static void PrintChartContents(string firstName, string lastName, int age)
        {
            string formatStringIntegral = "{0, -13} {1, -9} {2, 6:N0}";

            Console.WriteLine(formatStringIntegral, 
                            firstName,
                            lastName,
                            age);
        }

        public static void PrintTotalTabulated(int total)
        {
            string formatStringIntegral = "{0, 13} {1, -9} {2, 6:N0}";
            string empty = "";
            string title = "Total:";

            Console.WriteLine(formatStringIntegral,
                            empty,
                            title,
                            total);
        }

        public static void PrintCountTotal(int count)
        {
            string formatStringIntegral = "{0, 13:N0} {1, -9} {2, 6:N0}";
            string empty = "";
            string title = "Count:";

            Console.WriteLine(formatStringIntegral,
                empty,
                title,
                count);
        }

        public static void PrintAverage(double average)
        {
            string formatStringIntegral = "{0, 13:N0} {1, -9} {2, 6:N0}";
            string empty = "";
            string title = "Average:";

            Console.WriteLine(formatStringIntegral,
                empty,
                title,
                average);
        }

        public static void Usage(string usage)
        {
            Console.WriteLine(usage);
        }

        public static void FileNotFound(string error)
        {
            Console.WriteLine(error);
        }

        public static void TryError(string error)
        {
            Console.WriteLine(error);
        }
    }
}
