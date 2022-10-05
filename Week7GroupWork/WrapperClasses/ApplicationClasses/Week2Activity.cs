using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.Services;

namespace Week7GroupWork.WrapperClasses.ApplicationClasses
{
    internal class Week2Activity
    {
        public void Run()
        {
            DrawPage();
            int j = 1;
            double ave = 0, sum = 0;
            ZConsole.Write("How many numbers would you like to store in an array? ", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.CENTER, yOffset: 6, xOffset: 0);
            int n = Int32.Parse(Console.ReadLine());
            int[] arryNum = new int[n];
            Console.Clear();
            DrawPage();
            ZConsole.Write($"Input {n} elements in the array: ", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.CENTER, yOffset: 6, xOffset: 0);
            for (int i = 0; i < n; i++)
            { 
                ZConsole.Write($"Element {j}: ", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.CENTER, yOffset: 10, xOffset: 0); ;
                arryNum[i] = Int32.Parse(Console.ReadLine());
                sum += arryNum[i];
                j++;
                Console.Clear();
                ZConsole.Write($"Input {n} elements in the array: ", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.CENTER, yOffset: 6, xOffset: 0);
                DrawPage();
            }
            Console.Clear();
            DrawPage();
            ave = sum / n;
            ZConsole.Write("Elements of the array: ", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.CENTER, yOffset: 8, xOffset: 0);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arryNum[i]);
            } 
            ZConsole.Write($"Sum = {sum}", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.CENTER, yOffset: 10, xOffset: 0);
            ZConsole.Write($"Average = {Math.Round(ave, 3)}", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.CENTER, yOffset: 12, xOffset: 0);
            ZConsole.Write("Press any key to move back...", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.CENTER, yOffset: 16, xOffset: 0);
            Console.ReadKey();
        }
        private void DrawPage()
        {
            ZConsole.DrawBox(0, Console.WindowWidth - 1, 0, 2);
            ZConsole.Write("Week 2 Problem 1", 0, 1, null, null, flag: ZConsole.ConsoleFormatFlags.CENTER);
            ZConsole.Write("======ARRAYS======", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.CENTER, yOffset: 4, xOffset: 0);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, 3, Console.WindowHeight - 2);
            ZConsole.DrawClosedPipe(5, 0, Console.WindowWidth - 1);
        }
    }
}