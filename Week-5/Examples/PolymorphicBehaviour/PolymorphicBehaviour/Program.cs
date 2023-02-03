using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicBehaviour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Polymorphic Behaviour Demo";

            DerivedClass derivedClass = new DerivedClass();
            BaseClass baseClass = derivedClass;
            object objectClass = baseClass;

            Console.WriteLine(derivedClass);
            Console.WriteLine(baseClass);
            Console.WriteLine(objectClass);

            Console.WriteLine("\n");

            DerivedClass derived = new DerivedClass();
            BaseClass baseC = new BaseClass();

            baseC.OuterPrint();
            derived.OuterPrint();
        }
    }
}
