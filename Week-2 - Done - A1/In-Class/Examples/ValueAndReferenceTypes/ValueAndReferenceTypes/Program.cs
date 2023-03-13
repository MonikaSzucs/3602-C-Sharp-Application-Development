using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Value and Reference Types";

            int va = 100;
            int vb = va;

            Console.WriteLine($"va: {va}  vb: {vb}");
            vb = 200;
            Console.WriteLine($"va: {va}  vb: {vb}");

            Widget ra = new Widget();
            ra.Value = 100;
            Widget rb = ra;

            Console.WriteLine($"ra: {ra.Value}  rb: {rb.Value}");
            rb.Value = 200;
            Console.WriteLine($"ra: {ra.Value}  rb: {rb.Value}");
        }
    }
}
