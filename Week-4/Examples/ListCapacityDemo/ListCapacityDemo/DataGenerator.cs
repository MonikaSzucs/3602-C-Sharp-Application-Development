using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCapacityDemo
{
    class DataGenerator
    {
        public static IntCapacityRecordList GetIntCapacityRecords(int preSize = 0)
        {
            const int UpperLimit = 50;
            IntegerList integers;

            if (preSize > 0)
            {
                integers = new IntegerList(preSize);
            }
            else
            {
                integers = new IntegerList();
            }

            IntCapacityRecordList recordList = new IntCapacityRecordList();
            recordList.Add(new IntCapacityRecord { ListCount = integers.Count, ListCapacity = integers.Capacity });

            for (int count = 0; count < UpperLimit; count++)
            {
                integers.Add(count);
                recordList.Add(new IntCapacityRecord { ListCount = integers.Count, ListCapacity = integers.Capacity });
            }

            return recordList;
        }
    }
}
