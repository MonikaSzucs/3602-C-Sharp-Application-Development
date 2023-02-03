using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCapacityDemo
{
    class ConsolePrinter
    {
        public static void PrintList(IntCapacityRecordList list)
        {
            Console.WriteLine("{0, 9} {1, 9}", "Elements", "Capacity");
            Console.WriteLine(new string('-', 20));
            
            foreach (IntCapacityRecord element in list)
            {
                Console.WriteLine($"{element.ListCount, 9} {element.ListCapacity, 9}");
            }
        }
    }
}
