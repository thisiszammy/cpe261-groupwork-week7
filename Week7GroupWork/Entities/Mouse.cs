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
                    Run("Jerry");
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
            string[] frames = { $"Jerry is retreating.", $"Jerry is retreating..", $"Jerry is retreating...", $"Jerry is retreating   " };
            TextAnimation.TextAnimation1(frames, 100);
        }
        public void UserInput()
        {
            Console.Clear();
            Console.CursorVisible = true;
            Console.WriteLine($"Calculating Jerry's Velocity...\n\n");
            Console.Write("Enter distance traveled (in meters): ");
            double distanceTraveled = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter total time elapsed (in seconds): ");
            double timeElapsed = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nJerry is moving at {GetVelocity(distanceTraveled, timeElapsed)} m/s.");
            Console.WriteLine("\nPress any key to go back.");
            Console.ReadKey(true);
        }
        public override double GetVelocity(double distance, double time)
        {

            return Math.Round((distance / time), 2);
        }

        public void Eat()
        {
            string[] frames = { $"Jerry is eating.", $"Jerry is eating..", $"Jerry is eating...", $"Jerry is eating   " };
            TextAnimation.TextAnimation1(frames, 100, "Jerry", "eating");
        }
        public void Drink()
        {
            string[] frames = { $"Jerry is drinking.", $"Jerry is drinking..", $"Jerry is drinking...", $"Jerry is drinking   " };
            TextAnimation.TextAnimation1(frames, 100, "Jerry", "drinking");
        }
    }
}
