using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Math Class";

            double result01 = Math.Sin(30 * Math.PI / 180); // 0.4999
            double result02 = Math.Cos(30 * Math.PI / 180); // 0.8660 
            double result03 = Math.Tan(30 * Math.PI / 180); // 0.5774 

            double result04 = Math.Sin(45 * Math.PI / 180); // 0.7071
            double result05 = Math.Cos(45 * Math.PI / 180); // 0.7071 
            double result06 = Math.Tan(45 * Math.PI / 180); // 0.9999 

            double result07 = Math.Sin(60 * Math.PI / 180); // 0.8660 
            double result08 = Math.Cos(60 * Math.PI / 180); // 0.5000
            double result09 = Math.Tan(60 * Math.PI / 180); // 1.7321 

            double result10 = Math.Sqrt(2);                 // 1.4142
            double result11 = Math.Abs(15);                 // 15
            double result12 = Math.Abs(-15);                // 15

            double result13 = Math.Pow(3.446, 2.11245);     // 13.647454299617072
            int result14 = (int)Math.Pow(4, 2);             // 16 is this the best way to calculate
                                                            //    the square of a number?
        }
    }
}
