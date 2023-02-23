using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryInfoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               // string dirName = @"C:\Program Files";
                string dirName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                DirectoryInfo dir = new DirectoryInfo(dirName);

                FileAttributes fa;

                Console.WriteLine($"Directory: {dir.FullName}");
                Console.WriteLine($"Parent   : {dir.Parent.FullName}");
                Console.WriteLine($"Root     : {dir.Root.FullName}\n\n");

                Console.Write("Press enter to see subdirectories in {0}: ", dirName);
                Console.ReadLine();

                Console.WriteLine($"Subdirectories in {dirName}");
                Console.WriteLine($"{"Name", -40} {"File Count", 10}");
                Console.WriteLine(new string('-', 51));

                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    Console.WriteLine($"{subDir.Name, -40} {subDir.GetFiles().Count(), 10:N0}");
                }

                Console.Write($"\nPress enter to see files in {dirName}: ");
                Console.ReadLine();

                Console.WriteLine($"\n\nFiles in {dirName}");
                Console.WriteLine($"{"Name", -30} {"Attributes"}");
                Console.WriteLine(new string('-', 41));

                foreach (FileInfo file in dir.GetFiles())
                {
                    fa = file.Attributes;
                    Console.WriteLine($"{file.Name, -30} {fa.ToString()}");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}\n");
            }
        }
    }
}
