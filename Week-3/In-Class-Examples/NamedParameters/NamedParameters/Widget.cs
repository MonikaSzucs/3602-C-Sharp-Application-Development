using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    class Widget
    {
        public int Id { get; }
        public string Description { get; }
        public decimal Price { get; }

        public Widget(int id, string description, decimal price)
        {
            Id = id;
            Description = description;
            Price = price;
        }
    }
}
