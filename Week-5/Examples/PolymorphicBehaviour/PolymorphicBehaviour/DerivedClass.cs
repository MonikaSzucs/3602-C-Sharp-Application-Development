using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicBehaviour
{
    class DerivedClass : BaseClass
    {
        public override void OuterPrint(string data = "derived")
        {
            base.OuterPrint(data);
            innerPrintProtected(data);            
        }
    }
}
