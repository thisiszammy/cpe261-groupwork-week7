using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7GroupWork.Entities
{
    public class Circle : Shape
    {
        public override double CalculateSurfaceArea()
        {
            return Width * Width * Math.PI;
        }
    }
}

