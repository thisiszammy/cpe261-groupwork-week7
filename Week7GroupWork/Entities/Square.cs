using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7GroupWork.Entities
{
    class Square : Shape
    {
        public Square()
        {
        }
        public Square(double width) : base(width)
        {
        }

        public override void UserInput()
        {
            Console.WriteLine("\nCalculating the area of Square...\n");
            Console.Write("Enter a side length: ");
            Width = Convert.ToDouble(Console.ReadLine());
        }
        public override double CalculateSurface()
        {
            return Width * Width;
        }
    }
}
