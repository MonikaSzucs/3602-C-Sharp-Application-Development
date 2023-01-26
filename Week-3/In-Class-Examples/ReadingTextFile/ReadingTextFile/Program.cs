using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Add this namespace to use the StreamReader class.
using System.IO;

namespace ReadingTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Reading Text File Demo";
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
                Console.WriteLine("Usage: TextFileReadingExample datafile.txt");
                return;
            }

            if (!File.Exists(path))
            {
                Console.WriteLine("\nFile not found.\n");
                return;
            }

            try
            {
                // Attempt to open the file.  It will throw
                // an exception if there is a problem, 
                // hence the try/catch block.
                streamReader = new StreamReader(path);

                while ((lineData = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(lineData);
                }
            }

            // this block will execute if an exception is thrown in the try block
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}\n");
            }

            // this block always executes - used for resource cleanup.
            finally
            {
                if (streamReader != null) // always test for null                             
                {                         // StreamReader instantiation might have failed    
                    streamReader.Close(); // Will throw an exception if streamReader is null  
                                          // VERY bad practice to throw an exception in a     
                }                         // catch or finally block                          
            }
        }
    }
}
