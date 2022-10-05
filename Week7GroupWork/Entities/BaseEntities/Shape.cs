using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7GroupWork.Entities.BaseEntities
{
    public abstract class Shape
    {
        double length, width, height, radius;

        public Shape(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.Height = height;
        }

        public Shape(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public Shape(double radius)
        {
            this.radius = radius;
        }
        public Shape()
        {

        }
        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }
        public double Radius { get => radius; set => radius = value; }
        public double Height { get => height; set => height = value; }

        public abstract double GetArea();
        public abstract double GetSurfaceArea();
        public abstract double GetVolume();
    }
}
