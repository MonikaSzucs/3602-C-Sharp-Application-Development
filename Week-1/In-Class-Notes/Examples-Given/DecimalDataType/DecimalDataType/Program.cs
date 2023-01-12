using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Decimal Data Type";

            double doublePenny = 0.01d;

            double doubleDime = doublePenny + doublePenny + doublePenny + doublePenny + doublePenny
                              + doublePenny + doublePenny + doublePenny + doublePenny + doublePenny;

            double doubleDollar = doubleDime + doubleDime + doubleDime + doubleDime + doubleDime
                                + doubleDime + doubleDime + doubleDime + doubleDime + doubleDime;

            bool doubleEqual = doubleDollar == 1.00d;
            Console.WriteLine("Equal (double): {0}", doubleEqual);


            decimal decimalPenny = 0.01m;

            decimal decimalDime = decimalPenny + decimalPenny + decimalPenny + decimalPenny + decimalPenny
                                + decimalPenny + decimalPenny + decimalPenny + decimalPenny + decimalPenny;

            decimal decimalDollar = decimalDime + decimalDime + decimalDime + decimalDime + decimalDime
                                  + decimalDime + decimalDime + decimalDime + decimalDime + decimalDime;

            bool decimalEqual = decimalDollar == 1.00m;
            Console.WriteLine("Equal (decimal): {0}\n\n", decimalEqual);
        }
    }
}
