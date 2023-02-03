using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicBehaviour
{
    class BaseClass
    {
        public virtual void OuterPrint(string data = "base")
        {
            innerPrint($"Base Class Outer Print from {data}");
        }

        private void innerPrint(string source)
        {
            Console.WriteLine($"Printing from {source} [private].");
        }

        protected void innerPrintProtected(string source)
        {
            Console.WriteLine($"Printing from {source} [protected].");
        }
    }
}
