using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Week7GroupWork.Animation;
using Week7GroupWork.Entities.BaseEntities;
using Week7GroupWork.Interfaces;
using Week7GroupWork.Services;
using Week7GroupWork.WrapperClasses.ApplicationClasses;



namespace Week7GroupWork.Entities.Enums
{
    internal class Mouse : Animal, ICanEat, ICanDrink
    {
        Stack<ApplicationPageEnum> navigationHistory;

        public Mouse()
        {
            navigationHistory = new Stack<ApplicationPageEnum>();
        }

        public void StartJerry()
        {
            GotoPage(ApplicationPageEnum.Jerry);
        }

        private void DisplaySelection(string title, ApplicationPageEnumWrapper[] options)
        {
            var mainMenu = new MenuScroller(title, options);
            ApplicationPageEnum selectedPage = mainMenu.Run();
            GotoPage(selectedPage);
        }


        private void GotoPage(ApplicationPageEnum page, bool isPrev = false)
        {
            if (page != ApplicationPageEnum.Back && !isPrev) navigationHistory.Push(page);

            switch (page)
            {
                case ApplicationPageEnum.Jerry:
                    ShowJerryMenu();
                    break;
                case ApplicationPageEnum.Run:
                    Run(0, "Jerry");
                    StartJerry();
                    break;
                case ApplicationPageEnum.Retreat:
                    Back();
                    StartJerry();
                    break;
                case ApplicationPageEnum.CalculateVelocity:
                    UserInput();
                    StartJerry();
                    break;
                case ApplicationPageEnum.Eat:
                    Eat();
                    StartJerry();
                    break;
                case ApplicationPageEnum.Drink:
                    Drink();
                    StartJerry();
                    break;
                case ApplicationPageEnum.Back:
                    var w6a2 = new Week6Assignment2();
                    w6a2.Run();
                    break;
                    //navigationHistory.Pop();
                    //GotoPage(navigationHistory.Peek(), true);
                    //return;
            }
            //GotoPage(ApplicationPageEnum.Back, true);
        }

        private void ShowJerryMenu()
        {
            DisplaySelection("JERRY MENU", new ApplicationPageEnumWrapper[]
            {
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Run),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Retreat),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.CalculateVelocity),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Eat),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Drink),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Back)
            });
        }

        public override void Back()
        {
            string[] frames = { $"Jerry is retreating.  ", $"Jerry is retreating.. ", $"Jerry is retreating...", $"Jerry is retreating   " };
            TextAnimation.TextAnimation1(frames, 100, "Jerry", "retreating");
        }
        public void UserInput()
        {
            Console.Clear();
            Console.CursorVisible = true;

            ZConsole.DrawBox(0, Console.WindowWidth - 1, 0, 2);
            ZConsole.Write("Calculating Jerry's Velocity", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_CENTER, yOffset: 1);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, 3, Console.WindowHeight - 5);
            ZConsole.DrawBox(0, Console.WindowWidth - 1, Console.WindowHeight - 4, Console.WindowHeight - 2);
            ZConsole.Write("Enter distance traveled (in meters): ", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 5, xOffset: 2);
            double distanceTraveled = Convert.ToDouble(Console.ReadLine());

            ZConsole.Write("Enter total time elapsed (in seconds): ", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 6, xOffset: 2);
            double timeElapsed = Convert.ToDouble(Console.ReadLine());

            ZConsole.Write($"Jerry is moving at {GetVelocity(distanceTraveled, timeElapsed)} m/s.", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 8, xOffset: 2);

            Console.CursorVisible = false;
            ZConsole.Write("Press any key to go back.", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.BOTTOM_LEFT, yOffset: 3, xOffset: 2);
            Console.ReadKey(true);
        }
        public override double GetVelocity(double distance, double time)
        {

            return Math.Round((distance / time), 2);
        }

        public void Eat()
        {
            string[] frames = { $"Jerry is eating.  ", $"Jerry is eating.. ", $"Jerry is eating...", $"Jerry is eating   " };
            TextAnimation.TextAnimation1(frames, 100, "Jerry", "eating");
        }
        public void Drink()
        {
            string[] frames = { $"Jerry is drinking.  ", $"Jerry is drinking.. ", $"Jerry is drinking...", $"Jerry is drinking   " };
            TextAnimation.TextAnimation1(frames, 100, "Jerry", "drinking");
        }
    }
}
