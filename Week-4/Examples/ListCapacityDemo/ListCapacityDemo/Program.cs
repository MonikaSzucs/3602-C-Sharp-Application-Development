using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCapacityDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "List Capacity Demo";

            IntCapacityRecordList list = DataGenerator.GetIntCapacityRecords();
            ConsolePrinter.PrintList(list);
        }
    }
}
