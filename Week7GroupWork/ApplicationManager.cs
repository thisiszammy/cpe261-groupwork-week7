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
                case ApplicationPageEnum.W6A1:
                    RunWeek6Assignment1App();
                    break;

                case ApplicationPageEnum.W6A2:

                    break;

                case ApplicationPageEnum.Back:
                    navigationHistory.Pop();
                    GotoPage(navigationHistory.Peek());
                    return;
            }
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
        public void ShowSimulatorMenu()
        {
            DisplaySelection("SIMP 7 MENU", new ApplicationPageEnumWrapper[]
            {
                new ApplicationPageEnumWrapper(ApplicationPageEnum.W6A1),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.W6A2),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.W6A3),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.W6A4),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Back)
            });
        }
        private void RunExit()
        {
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
            ShowMainMenu();
        }
        void RunWeek6Assignment1App()
        {
            Console.Clear();
            Console.WriteLine("1] Full Execute");
            Console.WriteLine("2] Partial Execute");

            var entry = Console.ReadLine();

            if (entry == "1")
            {
                week6Assignment1Wrapper.FullExecute();
            }
            else
            {
                week6Assignment1Wrapper.PartialExecute();
            }

            week6Assignment1Wrapper.ShowStorageContent();
        }
    }
}
