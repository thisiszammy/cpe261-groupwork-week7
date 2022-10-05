using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.Entities.BaseEntities;

namespace Week7GroupWork.Entities
{
    public class Triangle : Shape
    {
        public Triangle(double length, double width) 
            : base(length, width)
        {

        }

        public override double GetArea()
        {
            return Length * Width / 2;
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public override double GetVolume()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Shape: Triangle, Height: {Length.ToString("N2")}, Base: {Width.ToString("N2")} " +
                $", Area: {GetArea().ToString("N2")}";
        }
    }
}
