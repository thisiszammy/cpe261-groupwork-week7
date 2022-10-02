using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7GroupWork.Entities
{
    class Parallelogram : Shape
    {
        public Parallelogram()
        {
        }
        public Parallelogram(double width, double height) : base(width, height)
        {
        }

        public override void UserInput()
        {
            Console.WriteLine("\nCalculating the area of Parallelogram...\n");
            Console.Write("Enter base length: ");
            Width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height length: ");
            Height = Convert.ToDouble(Console.ReadLine());
        }
        public override double CalculateSurface()
        {
            return Width * Height;
        }
    }
}
