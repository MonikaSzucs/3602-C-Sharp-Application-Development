using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicBehaviour
{
    class BaseClass
    {
        // The equal to is a optional parameter  which can or cannot be passed.
        // If nothing passed then it will make the data equal to base
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
