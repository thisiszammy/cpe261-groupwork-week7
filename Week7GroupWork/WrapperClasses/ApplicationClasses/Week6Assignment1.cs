using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.Entities;
using Week7GroupWork.Entities.BaseEntities;

namespace Week7GroupWork.WrapperClasses.ApplicationClasses
{
    public class Week6Assignment1
    {
        int storageCursor;
        Shape[] shapes;

        public Shape[] Shapes { get => shapes; set => shapes = value; }

        public Week6Assignment1(int storageSize)
        {
            shapes = new Shape[storageSize];
            storageCursor = 0;
        }

        public Week6Assignment1(Shape[] shapes)
        {
            this.shapes = shapes;

            for(int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] == null)
                {
                    storageCursor = i;
                    return;
                }
            }
        }

        public void PromptInputStorageSize()
        {
            int storageSize;
            Console.WriteLine("Please Enter Storage Size: ");
            var entry = Console.ReadLine();

            if(!int.TryParse(entry, out storageSize))
            {
                Console.WriteLine("Invalid Value Entered!");
                PromptInputStorageSize();
                return;
            }
            shapes = new Shape[storageSize];
            storageCursor = 0;
        }
        public void PromptInputRectangles()
        {
            int rectCount = 0;
            Console.WriteLine("How many rectangles would you like to input?");
            var entry = Console.ReadLine();

            if(!int.TryParse(entry, out rectCount))
            {
                Console.WriteLine("Invalid Value Entered!");
                PromptInputRectangles();
                return;
            }

            if(shapes.Length-storageCursor-1 == 0)
            {
                Console.WriteLine("Shape Storage is full!");
                return;
            }

            double length, width;
            for(int i = 0; i < rectCount; i++)
            {
                shapesEntry:
                Console.WriteLine("Rectangle {0}:", i + 1);
                Console.Write("\tEnter Length: ");
                var dimenEntry = Console.ReadLine();
                if(!double.TryParse(dimenEntry, out length))
                {
                    Console.WriteLine("Invalid Value Entered!");
                    goto shapesEntry;
                }

                Console.Write("\tEnter Width: ");
                dimenEntry = Console.ReadLine();
                if (!double.TryParse(dimenEntry, out width))
                {
                    Console.WriteLine("Invalid Value Entered!");
                    goto shapesEntry;
                }

                shapes[storageCursor] = new Rectangle(length, width);
                storageCursor++;
            }
        }
        public void PromptInputTriangles()
        {
            int rectCount = 0;
            Console.WriteLine("How many triangles would you like to input?");
            var entry = Console.ReadLine();

            if (!int.TryParse(entry, out rectCount))
            {
                Console.WriteLine("Invalid Value Entered!");
                PromptInputRectangles();
                return;
            }

            if (shapes.Length - storageCursor - 1 == 0)
            {
                Console.WriteLine("Shape Storage is full!");
                return;
            }

            double height, _base;
            for (int i = 0; i < rectCount; i++)
            {
                shapesEntry:
                Console.WriteLine("Triangle {0}:", i + 1);
                Console.Write("\tEnter Height: ");
                var dimenEntry = Console.ReadLine();
                if (!double.TryParse(dimenEntry, out height))
                {
                    Console.WriteLine("Invalid Value Entered!");
                    goto shapesEntry;
                }

                Console.Write("\tEnter Base: ");
                dimenEntry = Console.ReadLine();
                if (!double.TryParse(dimenEntry, out _base))
                {
                    Console.WriteLine("Invalid Value Entered!");
                    goto shapesEntry;
                }

                shapes[storageCursor] = new Triangle(height, _base);
                storageCursor++;
            }
        }
        public void PromptInputCircles()
        {
            int rectCount = 0;
            Console.WriteLine("How many circles would you like to input?");
            var entry = Console.ReadLine();

            if (!int.TryParse(entry, out rectCount))
            {
                Console.WriteLine("Invalid Value Entered!");
                PromptInputRectangles();
                return;
            }

            if (shapes.Length - storageCursor - 1 == 0)
            {
                Console.WriteLine("Shape Storage is full!");
                return;
            }

            double radius;
            for (int i = 0; i < rectCount; i++)
            {
                shapesEntry:
                Console.WriteLine("Circle {0}:", i + 1);
                Console.Write("\tEnter Radius: ");
                var dimenEntry = Console.ReadLine();
                if (!double.TryParse(dimenEntry, out radius))
                {
                    Console.WriteLine("Invalid Value Entered!");
                    goto shapesEntry;
                }

                shapes[storageCursor] = new Circle(radius);
                storageCursor++;
            }
        }
        public void DeleteRectangles()
        {
            for(int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] == null) continue;
                if (shapes[i].GetType() == typeof(Rectangle)) shapes[i] = null;
            }
        }
        public void DeleteTriangles()
        {
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] == null) continue;
                if (shapes[i].GetType() == typeof(Triangle)) shapes[i] = null;
            }
        }
        public void DeleteCircles()
        {
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] == null) continue;
                if (shapes[i].GetType() == typeof(Circle)) shapes[i] = null;
            }
        }

        public void ShowAllShapes()
        {
            foreach(var item in Shapes)
            {
                if (item == null) continue;
                Console.WriteLine(item.ToString());
            }
        }

    }
}
