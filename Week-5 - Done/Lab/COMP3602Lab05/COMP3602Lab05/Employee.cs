using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3602Lab05
{
    abstract class Employee : Payable
    {
        public Employee(int id) 
            : base(id)
        { 
        }
    }
}
