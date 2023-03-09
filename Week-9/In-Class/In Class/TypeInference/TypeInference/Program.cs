using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeInference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Type Inference Demo";

            //var newInt;  //declare and assign in the same line

            var intValue = 100;
            var unsignedValue = 100U;
            var longValue = 100L;
            var unsignedLongValue = 100UL;
            var doubleValue = 100.0;
            var floatValue = 100.0f;
            var decimalValue = 100m;
            var stringValue = "One-Hundred";
            var charValue = 'h';
            var boolValue = true;

            Console.WriteLine("{0, -15} {1}\n{2}", "Value", "Type", new string('-', 24));

            Console.WriteLine("{0, -15} {1}\n{2, -15} {3}\n{4, -15} {5}\n{6, -15} {7}\n{8, -15:N1} {9}\n{10, -15:N1} {11}\n{12, -15:N1} {13}\n{14, -15} {15}\n{16, -15} {17}\n{18, -15} {19}\n", 
                               intValue,
                               intValue.GetType().Name,
                               unsignedValue,
                               unsignedValue.GetType().Name,
                               longValue,
                               longValue.GetType().Name,
                               unsignedLongValue,
                               unsignedLongValue.GetType().Name,
                               doubleValue,
                               doubleValue.GetType().Name,
                               floatValue,
                               floatValue.GetType().Name,
                               decimalValue,
                               decimalValue.GetType().Name,
                               stringValue,
                               stringValue.GetType().Name,
                               charValue,
                               charValue.GetType().Name,
                               boolValue,
                               boolValue.GetType().Name);


            PersonCollectionWithAVeryVeryVeryVeryVeryLongName people1
                = new PersonCollectionWithAVeryVeryVeryVeryVeryLongName();

            var people2 = new PersonCollectionWithAVeryVeryVeryVeryVeryLongName();
        }
    }
}
