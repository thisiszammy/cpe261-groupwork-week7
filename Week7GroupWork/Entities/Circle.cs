﻿using System;
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


    class Circle : Shape
    {
        public Circle()
        {
        }
        public Circle(double width) : base(width)
        {
        }

        public override void UserInput()
        {
            Console.WriteLine("\nCalculating the area of Circle...\n");
            Console.Write("Enter radius length: ");
            Width = Convert.ToDouble(Console.ReadLine());
        }
        public override double CalculateSurface()
        {
            double temp = Math.PI * Width * Width;

            return Math.Round(temp, 2);
        }
    }
}
