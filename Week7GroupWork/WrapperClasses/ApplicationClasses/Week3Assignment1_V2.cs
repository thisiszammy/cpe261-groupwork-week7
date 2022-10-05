using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.Services;

namespace Week7GroupWork.WrapperClasses.ApplicationClasses
{
    public class Week3Assignment1_V2 : Rectriangle
    {
        public void Display()
        {
            Console.Clear();
            int choose;
            Rectriangle one = new Rectriangle();
            one.Welcome();
            ZConsole.Write("1. Rectangle ", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.LEFT, yOffset: 6, xOffset: 1);
            Console.WriteLine();
            ZConsole.Write("2. Triangle\n", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.LEFT, yOffset: 7, xOffset: 1);
            ZConsole.Write("Select: ", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.LEFT, yOffset: 9, xOffset: 1);
            choose = int.Parse(Console.ReadLine());

            if (choose == 1)
            {
                Console.Clear();
                one.DrawPageRect();
                Rectriangle rect = new Rectriangle();
                ZConsole.Write("Enter Length of Rectangle: ", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.LEFT, yOffset: 6, xOffset: 1);
                rect.Length = double.Parse(Console.ReadLine());
                ZConsole.Write("Enter Width of Rectangle: ", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.LEFT, yOffset: 7, xOffset: 1);
                rect.Width = double.Parse(Console.ReadLine());
                rect.Rect_Perimeter();
                rect.Rect_Area();
                ZConsole.Write("Press any key to return to the main menu. ", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.LEFT, yOffset: 14, xOffset: 1);

            }

            else if (choose == 2)
            {
                Console.Clear();
                one.DrawPageTri();
                Rectriangle tri = new Rectriangle();
                ZConsole.Write("Enter base side of Right Triangle: ", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.LEFT, yOffset: 6, xOffset: 1);
                tri.Side1 = double.Parse(Console.ReadLine());
                ZConsole.Write("Enter adjacent side of Right Triangle: ", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.LEFT, yOffset: 7, xOffset: 1);
                tri.Side2 = double.Parse(Console.ReadLine());
                tri.Tri_Hypotenuse();
                tri.Tri_Perimeter();
                ZConsole.Write("Press any key to return to main menu. ", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.LEFT, yOffset: 14, xOffset: 1);
            }
            Console.ReadKey();
        }

    }
    public class Rectriangle
    {

        //fields
        private double length, width, area, peri;
        private double side1, side2, hyp;

        //properties
        public double Length
        {
            get { return this.length; }
            set { this.length = value; }
        }
        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        public double Side1
        {
            get { return this.side1; }
            set { this.side1 = value; }
        }
        public double Side2
        {
            get { return this.side2; }
            set { this.side2 = value; }
        }


        //methods
        public void Rect_Area()
        {
            area = length * width;
            ZConsole.Write($"Area of Rectangle: {area:f2}", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.LEFT, yOffset: 10, xOffset: 1);
        }

        public void Rect_Perimeter()
        {
            peri = (2 * length) + (2 * width);
            ZConsole.Write($"Perimeter of Rectangle: {peri:f2} ", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.LEFT, yOffset: 9, xOffset: 1);

        }

        public void Tri_Hypotenuse()
        {
            hyp = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
            ZConsole.Write($"Hypotenuse: {hyp:f2} ", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.LEFT, yOffset: 9, xOffset: 1);
        }
        public void Tri_Perimeter()
        {
            peri = side1 + side2 + hyp;
            ZConsole.Write($"Perimeter of Triangle: {peri:f2} ", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.LEFT, yOffset: 10, xOffset: 1);

        }

        public void Welcome()
        {
            ZConsole.DrawBox(0, Console.WindowWidth - 1, 0, 2);
            ZConsole.Write("Welcome to Rectriangle Calculator!!!", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.CENTER);
            ZConsole.Write("Select shape to calculate", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.CENTER, yOffset: 4, xOffset: 0);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, 3, Console.WindowHeight - 2);
            ZConsole.DrawClosedPipe(5, 0, Console.WindowWidth - 1);
        }

        public void DrawPageTri()
        {
            ZConsole.DrawBox(0, Console.WindowWidth - 1, 0, 2);
            ZConsole.Write("Welcome to Rectriangle Calculator!!!", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.CENTER);
            ZConsole.Write("======TRIANGLE======", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.CENTER, yOffset: 4, xOffset: 0);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, 3, Console.WindowHeight - 2);
            ZConsole.DrawClosedPipe(5, 0, Console.WindowWidth - 1);
        }

        public void DrawPageRect()
        {
            ZConsole.DrawBox(0, Console.WindowWidth - 1, 0, 2);
            ZConsole.Write("Welcome to Rectriangle Calculator!!!", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.CENTER);
            ZConsole.Write("======RECTANGLE======", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.CENTER, yOffset: 4, xOffset: 0);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, 3, Console.WindowHeight - 2);
            ZConsole.DrawClosedPipe(5, 0, Console.WindowWidth - 1);
        }


    }
}

