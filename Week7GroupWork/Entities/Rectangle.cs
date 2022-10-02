using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7GroupWork.Entities
{
    public class Rectangle : Shape
    {
        public override double CalculateSurfaceArea()
        {
            return Height * Width;
        }

        public override string ToString()
        {
            return $"Shape: Rectangle, Height: {Height.ToString("N2")}, Width:{Width.ToString("N2")}";
        }
    }
}
