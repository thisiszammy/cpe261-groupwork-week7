using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7GroupWork.Entities
{
    abstract class Shape
    {
        private double width;
        private double height;

        protected double Width
        {
            set { width = value; }
            get { return width; }
        }

        protected double Height
        {
            set { height = value; }
            get { return height; }
        }

        protected Shape()
        {
        }

        protected Shape(double width) : this()
        {
            Width = width;
        }
        protected Shape(double width, double height) : this(width)
        {
            Height = height;
        }

        public abstract void UserInput();

        public abstract double CalculateSurface();
    }
}
