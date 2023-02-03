using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInfoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Windows\notepad.exe";

            FileInfo info = new FileInfo(fileName);

            if (info.Exists)
            {
                Console.WriteLine("Details of file: {0}\n{1}", fileName, new string('-', 40));

                Console.WriteLine("Directory:     {0}", info.DirectoryName);
                Console.WriteLine("Extension:     {0}", info.Extension);
                Console.WriteLine("Attributes:    {0}", info.Attributes);
                Console.WriteLine("Last Modified: {0:ddd MMM d, yyyy  hh:mm tt}", info.LastWriteTime);
                Console.WriteLine("Last Accessed: {0:ddd MMM d, yyyy  hh:mm tt}", info.LastAccessTime);
                Console.WriteLine("Length:        {0:N0} bytes", info.Length);
            }
            else
            {
                Console.WriteLine("Could not find: {0}", fileName);
            }

            // Path Class Example

            Console.WriteLine("\n\nFileName:   {0}", fileName);
            Console.WriteLine("Extension:  {0}", Path.GetExtension(fileName));

            // Returns filename with modified extension as a string
            //  Does not alter the actual file name
            Console.WriteLine("Change Ext: {0}\n\n", Path.ChangeExtension(fileName, "bak"));
        }
    }
}
