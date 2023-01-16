using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Property Methods";

            // create two products - calling parameterized constructors
            ProductWithGettersSetters productA = new ProductWithGettersSetters(100, "Widget One", 455.00m);
            ProductWithPropertyMethods productB = new ProductWithPropertyMethods(200, "Widget Two", 178.45m);

            // get/set method calling code
            Console.WriteLine(productA.GetPrice());
            productA.SetPrice(400.00m);
            Console.WriteLine(productA.GetPrice());

            // property method calling code
            Console.WriteLine(productB.Price);
            productB.Price = 150.00m;
            Console.WriteLine(productB.Price);

            // Console.WriteLine invokes ToString method
            Console.WriteLine(productA);
            Console.WriteLine(productB);
        }
    }
}
