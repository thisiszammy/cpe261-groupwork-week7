using Figgle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.Entities.Enums;
using Week7GroupWork.Services;
using Week7GroupWork.WrapperClasses;

namespace Week7GroupWork
{
    internal class ApplicationManager
    {
        Week6Assignment1Wrapper week6Assignment1Wrapper;
        Stack<ApplicationPageEnum> navigationHistory;

        public ApplicationManager()
        {
            week6Assignment1Wrapper = new Week6Assignment1Wrapper();
            navigationHistory = new Stack<ApplicationPageEnum>();
        }
        public void Start()
        {
            Console.Title = "SIMPS 7";
            GotoPage(ApplicationPageEnum.LaunchApp);
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
                case ApplicationPageEnum.LaunchApp:
                    ShowMainMenu();
                    break;
                case ApplicationPageEnum.Start:
                    ShowSimulatorMenu();
                    break;
                case ApplicationPageEnum.About:
                    RunDisplayAboutInfo();
                    break;
                case ApplicationPageEnum.Exit:
                    RunExit();
                    break;
                case ApplicationPageEnum.ASS3:
                    // Assignment 3 Function
                    break;
                case ApplicationPageEnum.W2Act:
                    // Week 2 Activity
                    break;
                case ApplicationPageEnum.W3A1:
                    // Week 3 Assignment 1
                    break;
                case ApplicationPageEnum.W4A1:
                    // Week 4 Assignment 1
                    break;
                case ApplicationPageEnum.W4A2:
                    // Week 4 Assignment 2
                    break;
                case ApplicationPageEnum.W6A1:
                    // Week 6 Assignment 1
                    break;
                case ApplicationPageEnum.W6A2:
                    // Week 6 Assignment 2
                    break;
                case ApplicationPageEnum.Back:
                    navigationHistory.Pop();
                    GotoPage(navigationHistory.Peek(), true);
                    return;
            }
            GotoPage(ApplicationPageEnum.Back, true);
        }
        private void ShowMainMenu()
        {
            DisplaySelection("WELCOME TO SIMPS 7 SIMULATOR APP", new ApplicationPageEnumWrapper[]
            {
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Start),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.About),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Exit),
            });
        }
        private void ShowSimulatorMenu()
        {
            DisplaySelection("SIMP 7 MENU", new ApplicationPageEnumWrapper[]
            {
                new ApplicationPageEnumWrapper(ApplicationPageEnum.ASS3),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.W2Act),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.W3A1),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.W4A1),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.W4A2),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.W6A1),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.W6A2),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Back)
            });
        }
        private void RunExit()
        {
            Console.Clear();

            string x = FiggleFonts.Standard.Render("THANK YOU ! ! !", 0);
            x = x.Replace("\r", "");
            var message = x.Split('\n');

            ZConsole.Write(message, 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.MIDDLE_CENTER);
            Console.SetCursorPosition(0, 18);
            Environment.Exit(0);
        }
        private void RunDisplayAboutInfo()
        {
            Console.Clear();
            ZConsole.Init(Console.WindowWidth, Console.WindowHeight);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, 0, 2);
            ZConsole.Write("ABOUT", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_CENTER, yOffset: 1);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, 3, Console.WindowHeight - 5);
            ZConsole.Write("This program was created by:", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 4, xOffset: 2);
            ZConsole.Write("Abad, John Paul", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 6, xOffset: 2);
            ZConsole.Write("Antonio, Kenette John A. - Leader", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 7, xOffset: 2);
            ZConsole.Write("Abapo, Ryan Angelo", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 8, xOffset: 2);
            ZConsole.Write("Arranguez, Alren Vince", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 9, xOffset: 2);
            ZConsole.Write("Esmero, Farley", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 10, xOffset: 2);
            ZConsole.Write("Joaquino, Romnic James", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 11, xOffset: 2);
            ZConsole.Write("Zamoras, Michael Jay", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 12, xOffset: 2);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, Console.WindowHeight - 4, Console.WindowHeight - 2);
            ZConsole.Write("Thank you for using the app. Press any key to return to the menu.", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.BOTTOM_LEFT, yOffset: 3, xOffset: 2);

            Console.ReadKey(true);
            GotoPage(ApplicationPageEnum.Back, true);
        }
        private void RunWeek6Assignment1App()
        {
            Console.Clear();
            week6Assignment1Wrapper.Run();
        }
        private void Sample()
        {
            Console.Clear();
            Console.WriteLine("Running Week 1 Something...");
        }
    }
}
