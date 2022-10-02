using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.Entities;

namespace Week7GroupWork.UserInterface
{
    internal class CalculatorApp
    {
        public void Start()
        {
            Console.Title = "Area of a Shape Calculator.";
            RunMainMenu();
        }

        private void RunMainMenu()
        {
            string prompt = "[MAIN MENU]\nWelcome to the Antonio's Area of a Shape Calculator. " +
                "\nNavigate through the options by pressing the ARROW Keys or WASD Keys." +
                "\nPress ENTER to select an option.\n";
            string[] options = { "Start", "About", "Exit" };
            var mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunCalculator();
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
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey(true);
            Environment.Exit(0);

        }
        private void DisplayAboutInfo()
        {
            Console.Clear();

            Console.WriteLine("[ABOUT]");
            Console.WriteLine("This program was created by Kenette John A. Antonio.");
            Console.WriteLine("Thank you for using the app.\n");
            Console.WriteLine("Press any key to return to the MAIN MENU.");
            Console.ReadKey(true);
            RunMainMenu();
        }
        private void RunCalculator()
        {
            Shape[] shapes = new Shape[6];
            double[] areas = new double[6];

            string prompt = "[CALCULATOR MENU]\nChoose which shape you wanted to calculate the area. " +
                    "\nNavigate through the options by pressing the ARROW Keys or WASD Keys." +
                    "\nPress ENTER to select an option.\n";
            string[] options = { "Triangle", "Rectangle", "Circle", "Square", "Parallelogram", "Rhombus", "Back" };
            var calculatorMenu = new Menu(prompt, options);
            int selectedIndex = calculatorMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    shapes[0] = new Triangle();
                    Console.CursorVisible = true;
                    shapes[0].UserInput();
                    areas[0] = shapes[0].CalculateSurface();
                    Console.WriteLine($"\nArea: {areas[0]}");
                    Console.WriteLine("\nPress any key to return to the CALCULATOR MENU.");
                    Console.CursorVisible = false;
                    Console.ReadKey(true);
                    RunCalculator();
                    break;

                case 1:
                    shapes[1] = new Rectangle();
                    Console.CursorVisible = true;
                    shapes[1].UserInput();
                    areas[1] = shapes[1].CalculateSurface();
                    Console.WriteLine($"\nArea: {areas[1]}");
                    Console.WriteLine("\nPress any key to return to the CALCULATOR MENU.");
                    Console.CursorVisible = false;
                    Console.ReadKey(true);
                    RunCalculator();
                    break;
                case 2:
                    shapes[2] = new Circle();
                    Console.CursorVisible = true;
                    shapes[2].UserInput();
                    areas[2] = shapes[2].CalculateSurface();
                    Console.WriteLine($"\nArea: {areas[2]}");
                    Console.WriteLine("\nPress any key to return to the CALCULATOR MENU.");
                    Console.CursorVisible = false;
                    Console.ReadKey(true);
                    RunCalculator();
                    break;
                case 3:
                    shapes[3] = new Square();
                    Console.CursorVisible = true;
                    shapes[3].UserInput();
                    areas[3] = shapes[3].CalculateSurface();
                    Console.WriteLine($"\nArea: {areas[3]}");
                    Console.WriteLine("\nPress any key to return to the CALCULATOR MENU.");
                    Console.CursorVisible = false;
                    Console.ReadKey(true);
                    RunCalculator();
                    break;
                case 4:
                    shapes[4] = new Parallelogram();
                    Console.CursorVisible = true;
                    shapes[4].UserInput();
                    areas[4] = shapes[4].CalculateSurface();
                    Console.WriteLine($"\nArea: {areas[4]}");
                    Console.WriteLine("\nPress any key to return to the CALCULATOR MENU.");
                    Console.CursorVisible = false;
                    Console.ReadKey(true);
                    RunCalculator();
                    break;
                case 5:
                    shapes[5] = new Rhombus();
                    Console.CursorVisible = true;
                    shapes[5].UserInput();
                    areas[5] = shapes[5].CalculateSurface();
                    Console.WriteLine($"\nArea: {areas[5]}");
                    Console.WriteLine("\nPress any key to return to the CALCULATOR MENU.");
                    Console.CursorVisible = false;
                    Console.ReadKey(true);
                    RunCalculator();
                    break;
                case 6:
                    RunMainMenu();
                    break;
            }
        }
    }
}
