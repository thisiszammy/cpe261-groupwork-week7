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
            throw new NotImplementedException();
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public override double GetVolume()
        {
            throw new NotImplementedException();
        }
    }
}
