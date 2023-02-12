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
            ItemList items = ReadCSVFile.GetCSV(args);
            //Console.WriteLine(items);

            Console.WriteLine(items.GetType());

            /*foreach (ItemList item in items)
            {
                Console.WriteLine(item);
            }*/
        }
    }
}
