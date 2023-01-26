using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypePassByReference
{
    class Program
    {
        const string labelOriginal = "Original Value:";
        const string labelInside = "Value inside PassByReference method:";
        const string labelAfter = "Value after PassByReference call:";

        static void Main(string[] args)
        {
            Console.Title = "Reference Type Pass By Reference Example";

            Widget widget = new Widget { Id = 1001 };

            Console.WriteLine($"{labelOriginal,-36} {widget.Id,6:N0}");

            add50PassByReference(ref widget);

            Console.WriteLine($"{labelAfter,-36} {widget.Id,6:N0}\n\n");
        }

        private static void add50PassByReference(ref Widget input)
        {
            input.Id += 50;
            Console.WriteLine($"{labelInside,-36} {input.Id,6:N0}");
        }
    }
}
