using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveInfoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BYTES_TO_GB = 1000000000;

            string formatString = "{0, -5} {1, -8} {2, -8} {3, -8} {4, 10} {5, 10}  {6, -10}";

            Console.WriteLine("Drive Listing for machine {0}\n", Environment.MachineName);

            DriveInfo[] drives = DriveInfo.GetDrives();

            Console.WriteLine(formatString
                              , "Name"
                              , "Type"
                              , "Format"
                              , "Ready"
                              , "Total (GB)"
                              , "Free (GB)"
                              , "Volume Label");

            Console.WriteLine(new string('-', 70));

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine(formatString
                                 , drive.Name
                                 , drive.DriveType
                                 , drive.IsReady ? drive.DriveFormat : "Unknown"
                                 , drive.IsReady ? "Yes" : "No"
                                 , drive.IsReady ? ((double)drive.TotalSize / BYTES_TO_GB).ToString("N2") : "Unknown"
                                 , drive.IsReady ? ((double)drive.TotalFreeSpace / BYTES_TO_GB).ToString("N2") : "Unknown"
                                 , drive.IsReady ? drive.VolumeLabel : "Unknown");
            }
        }
    }
}
