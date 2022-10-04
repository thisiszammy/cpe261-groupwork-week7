using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.Services;
using Week7GroupWork.WrapperClasses;

namespace Week7GroupWork.Scroller
{
    internal class Application
    {
        Week6Assignment1Wrapper week6Assignment1Wrapper;

        public Application()
        {
            week6Assignment1Wrapper = new Week6Assignment1Wrapper();
        }
        public void Start()
        {
            Console.Title = "SIMPS 7";
            RunMainMenu();
        }

        private void RunMainMenu()
        {
            string title = "WELCOME TO SIMPS 7 SIMULATOR APP";
            string[] options = { "Start", "About", "Exit" };
            var mainMenu = new Menu(title, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    SimulatorMenu();
                    break;

                case 1:
                    DisplayAboutInfo();
                    break;

                case 2:
                    Exit();
                    break;
            }
        }
        private void Exit()
        {
            //Console.WriteLine("\nPress any key to exit.");
            //Console.ReadKey(true);
            Environment.Exit(0);

        }
        private void DisplayAboutInfo()
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
            ZConsole.Write("Thank you for using the app. Press any key to return to the menu.", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.BOTTOM_LEFT, yOffset: 3,xOffset: 2);

            Console.ReadKey(true);
            RunMainMenu();
        }
        public void SimulatorMenu()
        {
            string title = "SIMP 7 MENU";
            string[] options = { "Week6Assignment1", "Mother", "Child", "Dog", "Cat", "Mouse", "Back" };
            var appMenu = new Menu(title, options);
            int selectedIndex = appMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunWeek6Assignment1App();
                    break;

                case 1:

                    break;

                case 6:
                    RunMainMenu();
                    break;
            }
        }

        void RunWeek6Assignment1App()
        {
            Console.Clear();
            Console.WriteLine("1] Full Execute");
            Console.WriteLine("2] Partial Execute");

            var entry = Console.ReadLine();

            if(entry == "1")
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
