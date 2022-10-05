using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Week7GroupWork.Services;
using static System.Collections.Specialized.BitVector32;

namespace Week7GroupWork.Animation
{
    internal class TextAnimation
    {
        public static void TextAnimation1(string[] frames, int delay = 100, string name = "Animal", string action = "moving")
        {
            Console.Clear();
            ZConsole.Init(Console.WindowWidth, Console.WindowHeight);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, 0, 2);
            ZConsole.Write("ANIMATION PANEL", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_CENTER, yOffset: 1);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, Console.WindowHeight - 4, Console.WindowHeight - 2);
            ZConsole.Write($"{name} is {action}. Press any key to return to the menu.", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.BOTTOM_LEFT, yOffset: 3, xOffset: 2);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, 3, Console.WindowHeight - 5);
            while (true)
            {
                foreach (var frame in frames)
                {
                    Console.CursorVisible = false;
                    ZConsole.Write(frame, 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.MIDDLE_CENTER, yOffset: 2);
                    Thread.Sleep(delay);
                }
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    break;
                }
            }
        }
        public static void TextAnimation2(string[] frames, int delay = 100, string name = "Animal", string action = "moving")
        {
            Console.Clear();
            ZConsole.Init(Console.WindowWidth, Console.WindowHeight);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, 0, 2);
            ZConsole.Write("ANIMATION PANEL", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_CENTER, yOffset: 1);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, Console.WindowHeight - 4, Console.WindowHeight - 2);
            ZConsole.Write($"{name} is {action}. Press any key to return to the menu.", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.BOTTOM_LEFT, yOffset: 3, xOffset: 2);

            //ZConsole.DrawBox(0, Console.WindowWidth - 1, 3, Console.WindowHeight - 5);

            while (true)
            {
                Console.CursorVisible = false;

                foreach (var frame in frames)
                {
                    Console.SetCursorPosition(10, 8);
                    Console.Write(frame);
                    Thread.Sleep(delay);
                }
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    break;
                }
            }
        }

        public static void TextAnimation3(string[] frames, int delay = 100, string name = "Animal", string action = "moving")
        {
            Console.Clear();
            ZConsole.Init(Console.WindowWidth, Console.WindowHeight);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, 0, 2);
            ZConsole.Write("ANIMATION PANEL", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_CENTER, yOffset: 1);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, Console.WindowHeight - 4, Console.WindowHeight - 2);
            ZConsole.Write($"{name} is {action}. Press any key to return to the menu.", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.BOTTOM_LEFT, yOffset: 3, xOffset: 2);

            //ZConsole.DrawBox(0, Console.WindowWidth - 1, 3, Console.WindowHeight - 5);

            Array.Reverse(frames);
            while (true)
            {
                Console.CursorVisible = false;

                foreach (var frame in frames)
                {
                    Console.SetCursorPosition(10, 8);
                    Console.Write(frame);
                    Thread.Sleep(delay);
                }
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    break;
                }
            }
        }
    }
}
