using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInitializers
{
    class Item
    {
        public int Id { get; }

        public Item(int id)
        {
            Id = id;
        }
    }
}
