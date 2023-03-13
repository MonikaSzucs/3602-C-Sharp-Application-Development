using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadonlyPropertiesVsReadonlyFields
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Readonly Properties vs Readonly Fields";

            Widget widget = new Widget(1001);
        }
    }
}
