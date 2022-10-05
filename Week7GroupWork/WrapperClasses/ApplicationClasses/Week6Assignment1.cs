using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.Entities;
using Week7GroupWork.Entities.BaseEntities;
using Week7GroupWork.Services;

namespace Week7GroupWork.WrapperClasses.ApplicationClasses
{
    public class Week6Assignment1
    {
        Shape[] shapes;
        public Shape[] Shapes { get => shapes; set => shapes = value; }


        public Week6Assignment1()
        {
            shapes = new Shape[5];
        }

        public void Run()
        {
            for(int i = 0; i < 5; i++)
            {
                int messageY = 15;
                DrawPage();
                switch (ShapeSelection())
                {
                    case 1:
                        ZConsole.Write("Enter Radius : ", 1, 12, null,null);
                        double radius = double.Parse(Console.ReadLine());
                        shapes[i] = new Circle(radius);
                        messageY = 14;
                        break;
                    case 2:
                        ZConsole.Write("Enter Length : ", 1, 12, null, null);
                        double length = double.Parse(Console.ReadLine());
                        ZConsole.Write("Enter Width : ", 1, 13, null, null);
                        double width = double.Parse(Console.ReadLine());
                        shapes[i] = new Rectangle(length, width);
                        break;
                    case 3:
                        ZConsole.Write("Enter Height : ", 1, 12, null, null);
                        double height = double.Parse(Console.ReadLine());
                        ZConsole.Write("Enter Base : ", 1, 13, null, null);
                        double _base = double.Parse(Console.ReadLine());
                        shapes[i] = new Triangle(height, _base);
                        break;
                }
                ZConsole.Write("Successfully Stored Shape! Press any key to continue...", 1, messageY, null,null);
                Console.ReadKey();
            }
            ShowStoredShapes();
            ZConsole.Write("Successfully Loaded Shapes! Press any key to return to menu...", 1, 15, null, null);
            Console.ReadKey();
        }

        private int ShapeSelection()
        {
            ZConsole.Write("1] Circle", 1, 6, null, null);
            ZConsole.Write("2] Rectangle", 1, 7, null, null);
            ZConsole.Write("3] Triangle", 1, 8, null, null);
            ZConsole.Write("Select Shape: ", 1, 10, null, null);
            return int.Parse(Console.ReadKey().KeyChar.ToString());
        }

        private void DrawPage()
        {
            Console.Clear();
            ZConsole.DrawBox(0, Console.WindowWidth - 1, 0, 2);
            ZConsole.Write("Week 6 Assignment 1", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.CENTER);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, 3, Console.WindowHeight - 2);
            ZConsole.Write($"You can store 5 shapes. Current Storage Capacity {GetStorageCapacityInUse()}/5",1,4, null, null);
            ZConsole.DrawClosedPipe(5, 0, Console.WindowWidth - 1);

        }

        private void ShowStoredShapes()
        {
            DrawPage();
            int ctr = 0;
            foreach(var item in shapes)
            {
                ZConsole.Write(item.ToString(), 1, 6 + ctr, null, null);
                ctr++;
            }
        }
        private int GetStorageCapacityInUse() => shapes.Where(x => x != null).Count();


    }
}
