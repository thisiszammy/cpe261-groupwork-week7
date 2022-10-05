using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.Entities.BaseEntities;

namespace Week7GroupWork.Entities
{
    public class Circle : Shape
    {
        public Circle(double radius) 
            : base(radius)
        {
        }
        public Circle()
        {

        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double GetSurfaceArea()
        {
            throw new NotImplementedException();
        }

        public override double GetVolume()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Shape: Circle, Radius: {Radius.ToString("N2")}, Area: {GetArea().ToString("N2")}";
        }
    }
}
