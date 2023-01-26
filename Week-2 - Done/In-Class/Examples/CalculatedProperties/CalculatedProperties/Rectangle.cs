using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatedProperties
{
    class Rectangle
    {
        private double width;
        private double height;
        // area is NOT stored as a field of the class

        public Rectangle() // default ctor (ctor means constructor)
        {                  // must write our own if we want the ability
                           // to create an empty object because we have
        }                  // written a paramaterized ctor   

        public Rectangle(double width, double height) // parameterized ctor
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        // Area is calculated on demand and exposed
        //   as a public, readonly property 
        public double Area
        {
            get { return width * height; }
        }
    }
}
