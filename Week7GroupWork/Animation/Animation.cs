using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7GroupWork.Animation
{
    internal class Animation
    {
        public static void TextAnimation(string[] frames, int delay = 100, string name = "Animal", string action = "moving")
        {
            Console.Clear();
            Console.SetCursorPosition(0, 20);
            Console.WriteLine($"{name} is {action}...\n");
            Console.WriteLine("Press any key to go back.");

            while (true)
            {
                foreach (var frame in frames)
                {
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(frame);
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
