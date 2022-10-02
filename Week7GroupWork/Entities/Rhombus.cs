using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7GroupWork.Entities
{
    class Rhombus : Shape
    {
        public Rhombus()
        {
        }
        public Rhombus(double width, double height) : base(width, height)
        {
        }

        public override void UserInput()
        {
            Console.WriteLine("\nCalculating the area of Rhombus...\n");
            Console.Write("Enter first diagonal length: ");
            Width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second diagonal length: ");
            Height = Convert.ToDouble(Console.ReadLine());
        }
        public override double CalculateSurface()
        {
            return Width * Height / 2;
        }
    }
}
