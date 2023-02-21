using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Inheritance Demo";

            Shape[] shapes =
            {
                new Circle(),
                new Triangle(),
                new Rectangle()
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Draw());
            }
        }
    }
}
