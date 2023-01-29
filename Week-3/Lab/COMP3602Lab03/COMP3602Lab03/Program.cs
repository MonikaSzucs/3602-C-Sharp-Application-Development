using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP3602Lab03";
            // This object lets you read from a file.
            StreamReader streamReader = null;

            string path;
            string lineData;

            ConsolePrinter.PrintChartTitle();
            ConsolePrinter.PrintChartLine();

            if (args.Length > 0)
            {
                path = args[0];
            }
            else
            {
                ConsolePrinter.Usage("Usage: COMP3602Lab03 data.txt");
                return;
            }

            if (!File.Exists(path))
            {
                ConsolePrinter.FileNotFound("\nFile not found.\n");
                return;
            }

            try
            {
                // Read entire file line-by-line and display to the screen.
                // The using block will automatically close the file and
                // cleanup the StreamReader instance when the block finishes
                using (streamReader = new StreamReader(path))
                {
                    int tabulated = 0;
                    int memberCount = 0;
                    while ((lineData = streamReader.ReadLine()) != null)
                    {
                        string[] members = lineData.Split(',');
                        int start = 0;
                        string firstName = "";
                        string lastName = "";
                        int age = 0;

                        foreach (var member in members)
                        {
                            if (start == 0)
                            {
                                firstName = member;
                            }
                            else if(start == 1)
                            {
                                lastName = member;
                            } else if(start == 2)
                            {
                                age = Int32.Parse(member);
                                tabulated += age;
                                ConsolePrinter.PrintChartContents(firstName, lastName, age);
                                start = 0;
                                memberCount++;
                            }
                            start++;
                        }
                    }

                    ConsolePrinter.PrintChartLine();

                    ConsolePrinter.PrintTotalTabulated(tabulated);
                    ConsolePrinter.PrintCountTotal(memberCount);

                    double averageCalculation = (double)tabulated / (double)memberCount;
                    ConsolePrinter.PrintAverage(averageCalculation);
                }
            }

            // this block will execute if an exception is thrown in the try block
            catch (Exception ex)
            {
                ConsolePrinter.TryError($"\n{ex.Message}\n");
            }
        }
    }
}
