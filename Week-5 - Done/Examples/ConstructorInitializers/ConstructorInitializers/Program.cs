using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Constructor Initializer Demo";

            InventoryItem part = new InventoryItem(101, "Nice Widget", 325.00m);
            Console.WriteLine($"ID: {part.Id} Desc: {part.Description} Price: {part.Price:N2}");
        }
    }
}
