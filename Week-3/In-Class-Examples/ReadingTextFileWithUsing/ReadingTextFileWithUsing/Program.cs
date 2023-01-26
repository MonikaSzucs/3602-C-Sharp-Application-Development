using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Add this namespace to use the StreamReader class.
using System.IO;

namespace ReadingTextFileWithUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Reading Text File Demo [With Using Block]";
            // This object lets you read from a file.
            StreamReader streamReader = null;

            string path; // = "";
            string lineData;

            if (args.Length > 0)
            {
                path = args[0];
            }
            else
            {
                Console.WriteLine("Usage: TextFileReadingExampleWithUsing datafile.txt");
                return;
            }

            if (!File.Exists(path))
            {
                Console.WriteLine("\nFile not found.\n");
                return;
            }

            try
            {
                // Read entire file line-by-line and display to the screen.
                // The using block will automatically close the file and
                // cleanup the StreamReader instance when the block finishes
                using (streamReader = new StreamReader(path))
                {
                    while ((lineData = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(lineData);
                    }
                }
            }

            // this block will execute if an exception is thrown in the try block
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}\n");
            }
        }
    }
}
