using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7GroupWork.Entities
{
    class Rectangle : Shape
    {
        public Rectangle()
        {
        }
        public Rectangle(double width, double height) : base(width, height)
        {
        }
        public override void UserInput()
        {
            Console.WriteLine("\nCalculating the area of Rectangle...\n");
            Console.Write("Enter width length: ");
            Width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height length: ");
            Height = Convert.ToDouble(Console.ReadLine());
        }

        public override double CalculateSurface()
        {
            return Width * Height;
        }
    }
    
    public class Circle : Shape
    {
        public override double CalculateSurfaceArea()
        {
            return 1;
        }
    }

}
