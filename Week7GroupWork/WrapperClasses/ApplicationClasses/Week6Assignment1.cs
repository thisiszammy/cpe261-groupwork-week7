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
        int storageSize;
        int storageCursor;
        Shape[] shapes;

        public int StorageSize { get => storageSize; set => storageSize = value; }
        public Shape[] Shapes { get => shapes; set => shapes = value; }

        public Week6Assignment1(int storageSize)
        {
            this.storageSize = storageSize;
            shapes = new Shape[storageSize];
            storageCursor = 0;
        }

        public Week6Assignment1(int storageSize, Shape[] shapes)
        {
            this.storageSize = storageSize;
            this.shapes = shapes;

            for(int i = 0; i < storageSize; i++)
            {
                if (shapes[i] == null)
                {
                    storageCursor = i - 1;
                    return;
                }
            }
        }

        public void Run()
        {
            PromptInputStorageSize();
            PromptInputRectangles();
        }
        
        public void PromptInputStorageSize()
        {
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

            if(storageSize-storageCursor-1 == 0)
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
