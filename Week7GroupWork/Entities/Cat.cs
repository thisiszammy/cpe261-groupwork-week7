using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Week7GroupWork.Animation;
using Week7GroupWork.Entities.BaseEntities;
using Week7GroupWork.Entities.Enums;
using Week7GroupWork.Interfaces;
using Week7GroupWork.Services;
using Week7GroupWork.WrapperClasses.ApplicationClasses;



namespace Week7GroupWork.Entities
{
    internal class Cat : Animal, ICanEat, ICanDrink
    {
        private string name;

        Stack<ApplicationPageEnum> navigationHistory;

        public Cat()
        {
            navigationHistory = new Stack<ApplicationPageEnum>();
        }
        public Cat(string name) : this()
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void StartCat()
        {
            GotoPage(ApplicationPageEnum.Cat);
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
                case ApplicationPageEnum.Cat:
                    ShowCatMenu();
                    break;
                case ApplicationPageEnum.Run:
                    Run(1, Name);
                    StartCat();
                    break;
                case ApplicationPageEnum.NameYourCat:
                    NameCat();
                    StartCat();
                    return;
                case ApplicationPageEnum.Retreat:
                    Back();
                    StartCat();
                    break;
                case ApplicationPageEnum.CalculateVelocity:
                    UserInput();
                    StartCat();
                    break;
                case ApplicationPageEnum.Eat:
                    Eat();
                    StartCat();
                    break;
                case ApplicationPageEnum.Drink:
                    Drink();
                    StartCat();
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

        private void ShowCatMenu()
        {
            DisplaySelection("CAT MENU", new ApplicationPageEnumWrapper[]
            {
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Run),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.NameYourCat),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Retreat),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.CalculateVelocity),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Eat),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Drink),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Back)
            });
        }


        public void NameCat()
        {
            Console.Clear();
            Console.CursorVisible = true;

            ZConsole.DrawBox(0, Console.WindowWidth - 1, 0, 2);
            ZConsole.Write("Naming Your Cat", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_CENTER, yOffset: 1);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, 3, Console.WindowHeight - 5);
            ZConsole.DrawBox(0, Console.WindowWidth - 1, Console.WindowHeight - 4, Console.WindowHeight - 2);
            ZConsole.Write("Enter the name of your cat: ", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 5, xOffset: 2);
            Name = Console.ReadLine();

            Console.CursorVisible = false;
            ZConsole.Write("New name has been set. Press any key to go back.", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.BOTTOM_LEFT, yOffset: 3, xOffset: 2);
            Console.ReadKey(true);
        }

        public override void Back()
        {
            Name ??= "Tom";
            //string[] frames = { $"{Name} is retreating.  ", $"{Name} is retreating.. ", $"{Name} is retreating...", $"{Name} is retreating   " };

            string[] frames = { @"
                            ▄▄█▄▄▄,          ▄▄▓▓█▓▓█▓▄╖                                        
                            ██████████▄▄▄▄▄▄███████████████,                   ,▄█`             
                            ███▀▀████████████████████████████▄▄,,,,,,,,,,▄▄▄▄██▀`               
                                ╙███████████████████████████▌`▀▀▀▀▀▀▀▀▀▀`                       
                                    ▀████████████████████████▀                                  
                                        ▀▀▀▀▀██████▄██████▀`                                    
                                        ▀███████▀██████                                         
                                                    ███                                         
                                                    ▄██▀                                        
                                                ▄▄██▀'                                          
                                                ▀▀                                              
                                                                                                ", @"
                               ,▄                                                               
                            ▄███████▄▄      ,▄▄▄▄████▓▓@▄▄                                      
                            ████████████████████████████████,                  ,▄               
                             ▀   ███████████████████████████████▄▄▄,,      ,▄▄█▀'               
                                  ▀██████████████████████████C    ""▀▀▀▀▀▀▀▀▀`                  
                                    ▀█████████▀▀▀▀██████████▌                                   
                                      ▀██, ██Q▄██ ▐███▀██████                                   
                                         ` ▀██▀▀  ▐██▌  ▀█████▄▄                                
                                                  ▐██▌     ▀▀▀██▌                               
                                                ,████        ██▀                                
                                             ▀██▀▀'        ██▀                                  
                                                                                                ", @"
                              ▄▄█▄▄▄,,                                                          
                            █████████████▄▄▄▄▄▄▄▄▄▄▄▄▄█████████▄                                
                            ███▀▀█████████████████████████████████▄▄                            
                                  ▀████████████████████████████████▄▀▀█▄▄▄▄,     ,,▄▄           
                                   ▐██████████████████▀▀▀""▀█████████▄▄▄▄▄ ▀▀▀▀▀▀▀▀▀▀           
                               ,▄██████████████▀▀▀▀`       ▐███████████████▄,                   
                              ▐██▀██▄                       ▀█████████,    ▀████                
                              ██   ▀▀`                        `▀▀▀▀▀████▄                       
                                                                       ▀██                      
                                                                        ██▌                     
                                                                        `▀""                    
                                                                                                ", @"
                                    ,▄                                                          
                                  ▄████████▄▄▄             ,▄╥▄æ▄▄▄▄▄▄,                         
                                  ████████████████▄▄▄▄▄█████████████████▀▀██▄▄,                 
                                   ▀   ▀██████████████████████████████████▄█▄▄███▄▄,            
                                       ╓████████████████████████████████████████████████▀       
                            ,,  ,,,▄▄▄████████████████████████▀     ▀███████▀▀    '""`'         
                            ▀██████████████▀  ▀▀▀▀████████▀▀                                    
                               - --`                                                            
                                                                    
                                                                    
                                                                    
                                                                                                ", @"
                                                                ,▄▄▄▄▄▄,    ,,,,,,              
                                  ╓▄▄▄,                    ,▄████████████▀▀▀▀▀▀▀▀▀▀▀██▄▄        
                                ▐██████████▄▄,       ,▄▄████████████████▌,▄            ▀▀█▄     
                                ▐███████████████████████████████████████████▄            ╙█L    
                                      ╙███████████████████████████████████████                  
                                      ,▄█████████████████████▀███████████▀█████▄                
                            ▄▄,,▄▄▄▄▄████████████████████▀▀    ▀▀██▀▀▀     ▀▀█▀▀                
                            ▀▀▀▀▀▀▀▀▀▀▀▀█████▀▀▀▀▀▀▀▀▀-                                         
                                       /█████                                                   
                                     ,▄███▀                                                     
                                 ,▄▄██▀""                                                       
                                 ▀▀▀                                                            
                                                                                                ", @"
                                                           ▄▄▄████▄▄  ,▄▄███▀▀▀▀▀▀▀▀██▄▄        
                                                      ▄▄██████████████▀▀               ▀██▄     
                             ╓▄██▄▄▄▄,            ▄▄███████████████████                  `▀     
                            ▐█████████████████████████████████████████""                        
                            ▀███████████████████████████████████████████▌                       
                                    ███████████████████████▀▀▀▀█████████                        
                                    j████████████████████▀         ╒███▌                        
                                     ████████████████▀▀            ▐███                         
                                    ╒█████▀▀▀▀▀▀▀▀███▄▄            ╙█▀                          
                                   ,█████▀          ▀████▄                                      
                                 ▄███▀▀                ▀███▄                                    
                             ▄▄███▀                       ▀▀                                    
                             ▀▀`                                                                
                                                                                                ", @"
                                                      ,▄▄▄▄▄,             ,▄▄▄███▀▀▀▀▀███╕      
                                                ,▄▄█████████████▄     ,▄██▀▀-                   
                            ,▄██████▄▄▄▄,,,▄▄██████████████████████▄██▀'                        
                            ████████████████████████████████████████                            
                            ▀█▀▀▀▀▀████████████████████████████████`                            
                                    `▀██████████████████▀█████████                              
                                       ▀▀█████████████▄   ▄██████▀                              
                                          `▀▀███▀▀'""▀███████████                               
                                             ▐██▄      ▀███████▀                                
                                              ╙██▌         ""▀▀▀                                
                                               ╙██                                              
                                                ▐█▌                                             
                                                                                                ", @"
                                                                              ,▄▄▄▄▄▄▄          
                                               ▄▄██████▄▄,                ,▄██▀▀                
                                            ▄███████████████▄           ▄██▀                    
                             ▄█████▄▄▄, ,,▄████████████████████▄     ▄██▀                       
                            █████████████████████████████████████▄██▀▀                          
                            ▀██▀▀▀██████████████████████████████▀                               
                                    ▀████████████████▌-▀█████▀▀▀                                
                                       ▀▀████████████████████▌                                  
                                           ▀▀▀█████▀███▄▄                                       
                                             ▄▄█████▄, ▀▀                                       
                                             ▀▀`   ▀█████µ                                      " };
            TextAnimation.TextAnimation3(frames, 100, Name, "retreating");
        }

        public void UserInput()
        {
            Name ??= "Tom";
            Console.Clear();
            Console.CursorVisible = true;

            ZConsole.DrawBox(0, Console.WindowWidth - 1, 0, 2);
            ZConsole.Write($"Calculating {Name}'s Velocity", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_CENTER, yOffset: 1);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, 3, Console.WindowHeight - 5);
            ZConsole.DrawBox(0, Console.WindowWidth - 1, Console.WindowHeight - 4, Console.WindowHeight - 2);
            ZConsole.Write("Enter distance traveled (in meters): ", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 5, xOffset: 2);
            double distanceTraveled = Convert.ToDouble(Console.ReadLine());

            ZConsole.Write("Enter total time elapsed (in seconds): ", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 6, xOffset: 2);
            double timeElapsed = Convert.ToDouble(Console.ReadLine());

            ZConsole.Write($"{Name} is moving at {GetVelocity(distanceTraveled, timeElapsed)} m/s.", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 8, xOffset: 2);

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
            Name ??= "Tom";
            string[] frames = { $"{Name} is eating.  ", $"{Name} is eating.. ", $"{Name} is eating...", $"{Name} is eating   " };
            TextAnimation.TextAnimation1(frames, 100, Name, "eating");
        }

        public void Drink()
        {
            Name ??= "Tom";
            string[] frames = { $"{Name} is drinking.  ", $"{Name} is drinking.. ", $"{Name} is drinking...", $"{Name} is drinking   " };
            TextAnimation.TextAnimation1(frames, 100, Name, "drinking");
        }
    }
}
