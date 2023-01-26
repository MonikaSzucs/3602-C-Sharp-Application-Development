using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Params / Output Parameter Example";

            createArrayV1();
            createArrayV2();
        }

        private static void createArrayV1()
        {
            // standard variable declaration
            //int minimum;
            //int maximum;
            //int count;
            //int sum;
            double average;

            processArray(out int minimum,
                         out int maximum,
                         out int count,
                         out int sum,
                         out  average,
                         5, 2, 9, 23, 15, 28, 7, 11);

            Console.WriteLine("Min: {0}\nMax: {1}\nCnt: {2}\nSum: {3}\nAvg: {4:n3}\n"
                            , minimum, maximum, count, sum, average);
        }

        private static void createArrayV2()
        {
            // inline variable declaration
            processArray(out int minimum,
                         out int maximum,
                         out int count,
                         out int sum,
                         out double average,
                         5, 2, 9, 23, 15, 28, 7, 11, 45,80, 90);

            Console.WriteLine("Min: {0}\nMax: {1}\nCnt: {2}\nSum: {3}\nAvg: {4:n3}\n"
                            , minimum, maximum, count, sum, average);
        }

        private static void processArray(out int minimum,
                                         out int maximum,
                                         out int count,
                                         out int sum,
                                         out double average,
                                         params int[] input)
        {
            sum = 0;
            
            foreach (int element in input)
            {
                sum += element;
            }

            count = input.Length;
            average = sum / (double)input.Length;
            Array.Sort(input);
            minimum = input[0];
            maximum = input[input.Length - 1];
        }
    }
}
