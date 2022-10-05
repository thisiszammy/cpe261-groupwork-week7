using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.Write("Select Shape to calculate: ");
            choose = int.Parse(Console.ReadLine());

            if (choose == 1)
            {
                Console.Clear();
                Rectriangle rect = new Rectriangle();
                Console.Write("Enter Length of Rectangle:");
                rect.Length = double.Parse(Console.ReadLine());
                Console.Write("Enter Width of Rectangle:");
                rect.Width = double.Parse(Console.ReadLine());
                rect.Rect_Perimeter();

            }

            else if (choose == 2)
            {
                Console.Clear();
                Console.Write("Enter base side of Right Triangle:");
                one.Side1 = double.Parse(Console.ReadLine());
                Console.Write("Enter adjacent side of Right Triangle:");
                one.Side2 = double.Parse(Console.ReadLine());
                one.Tri_Hypotenuse();
                one.Tri_Perimeter();

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
            Console.WriteLine("\nArea of Rectangle: {0} ", area);

        }

        public void Rect_Perimeter()
        {
            peri = (2 * length) + (2 * width);
            Console.WriteLine("\nPerimeter of Rectangle: {0} ", peri);

        }

        public void Tri_Hypotenuse()
        {
            hyp = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
            Console.WriteLine("\nHypotenuse: {0} ", hyp);
        }
        public void Tri_Perimeter()
        {
            peri = side1 + side2 + hyp;
            Console.WriteLine("Perimeter of Triangle: {0} ", peri);

        }

        public void Welcome()
        {

            Console.WriteLine("WELCOME BLABLABLA\n");
            Console.WriteLine("1. Rectangle ");
            Console.WriteLine("2. Triangle ");
        }


    }
}

