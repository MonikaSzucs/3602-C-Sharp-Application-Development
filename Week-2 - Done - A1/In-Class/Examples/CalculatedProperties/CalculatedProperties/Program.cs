using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatedProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculated Properties";

            Rectangle first = new Rectangle(10, 20);

            Rectangle second = new Rectangle();
            second.Height = 10;
            second.Width = 10;

            Console.WriteLine("First Rectangle area is:  {0}", first.Area);
            Console.WriteLine("Second Rectangle area is: {0}", second.Area);
        }
    }
}
