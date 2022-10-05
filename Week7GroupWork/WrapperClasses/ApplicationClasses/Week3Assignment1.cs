using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.Entities;

namespace Week7GroupWork.WrapperClasses.ApplicationClasses
{
    public class Week3Assignment1
    {
        public void Design()
        {
            Console.WriteLine("\n\t=========================================================");
        }
        public void Main()
        {
            Design();
            Console.WriteLine("\n\tCalculate for the Area of the Circle!");
            Circle pol = new Circle();

            inputRad(pol);
            
            Console.WriteLine("\n\tArea of the Circle = {0:F3}", pol.GetArea());
            Design();
            Console.WriteLine("\n\tPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Design();
            Console.WriteLine("\n\tCalculate for the Surface Area of the Rectangle!");
            Rectangle rec = new Rectangle();

            inputLW(rec);
            Console.WriteLine("\n\tSurface Area of the Rectangle = {0:F3}", rec.GetSurfaceArea());
            Design();
            Console.WriteLine("\n\tPress any key to exit...");
            Console.ReadKey(true);
        }
        public void inputRad(Circle rad)
        {
            Console.Write("\n\tEnter value for the radius: ");
            rad.Radius = double.Parse(Console.ReadLine());
        }
        public void inputLW(Rectangle rect)
        {
            Console.Write("\n\tEnter value for the length: ");
            rect.Length = double.Parse(Console.ReadLine());
            Console.Write("\tEnter value for the width: ");
            rect.Width = double.Parse(Console.ReadLine());
        }
    }
}