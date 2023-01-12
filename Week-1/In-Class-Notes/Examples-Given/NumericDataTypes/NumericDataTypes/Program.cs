using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Numeric Data Types";

            string formatStringHeading = "{0, -8} {1, 28} {2, 28} {3, 8}";
            string formatStringIntegral = "{0, -8} {1, 28:N0} {2, 28:N0} {3, 8:N0}";
            string formatStringFloating = "{0, -8} {1, 28:E} {2, 28:E} {3, 8:N0}";

            Console.WriteLine(formatStringHeading,
                    "C# Data",
                    "Minimum",
                    "Maximum",
                    "Size");

            Console.WriteLine(formatStringHeading,
                    "Type",
                    "Value",
                    "Value",
                    "(bytes)");

            Console.WriteLine(new string('-', 75));

            Console.WriteLine(formatStringIntegral,
                   "byte",
                   byte.MinValue,
                   byte.MaxValue,
                   sizeof(byte));

            Console.WriteLine(formatStringIntegral,
                   "sbyte",
                   sbyte.MinValue,
                   sbyte.MaxValue,
                   sizeof(sbyte));

            Console.WriteLine(formatStringIntegral,
                   "short",
                   short.MinValue,
                   short.MaxValue,
                   sizeof(short));

            Console.WriteLine(formatStringIntegral,
                   "ushort",
                   ushort.MinValue,
                   ushort.MaxValue,
                   sizeof(ushort));

            Console.WriteLine(formatStringIntegral,
                  "int",
                  int.MinValue,
                  int.MaxValue,
                  sizeof(int));

            Console.WriteLine(formatStringIntegral,
                   "uint",
                   uint.MinValue,
                   uint.MaxValue,
                   sizeof(uint));

            Console.WriteLine(formatStringIntegral,
                   "long",
                   long.MinValue,
                   long.MaxValue,
                   sizeof(long));

            Console.WriteLine(formatStringIntegral,
                   "ulong",
                   ulong.MinValue,
                   ulong.MaxValue,
                   sizeof(ulong));

            Console.WriteLine(formatStringFloating,
                   "float",
                   float.MinValue,
                   float.MaxValue,
                   sizeof(float));

            Console.WriteLine(formatStringFloating,
                   "double",
                   double.MinValue,
                   double.MaxValue,
                   sizeof(double));

            Console.WriteLine(formatStringFloating,
                   "decimal",
                   decimal.MinValue,
                   decimal.MaxValue,
                   sizeof(decimal));
        }
    }
}
