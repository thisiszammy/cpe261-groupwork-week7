using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.Entities.Enums;
using Week7GroupWork.Services;
using Week7GroupWork.Entities;

namespace Week7GroupWork.WrapperClasses.ApplicationClasses
{
    public class Week6Assignment2
    {

        Stack<ApplicationPageEnum> navigationHistory;

        public Week6Assignment2()
        {
            navigationHistory = new Stack<ApplicationPageEnum>();
        }

        public void Run()
        {
            GotoPage(ApplicationPageEnum.W6A2);
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
                case ApplicationPageEnum.W6A2:
                    ShowCatAndJerryMenu();
                    break;
                case ApplicationPageEnum.Cat:
                    var c = new Cat();
                    c.StartCat();
                    break;
                case ApplicationPageEnum.Jerry:
                    var j = new Mouse();
                    j.StartJerry();
                    break;
                case ApplicationPageEnum.Back:
                    GotoPage(ApplicationPageEnum.Start);
                    break;
                    //navigationHistory.Pop();
                    //GotoPage(navigationHistory.Peek(), true);
                    //return;
            }
            //GotoPage(ApplicationPageEnum.Back, true);
        }

        private void ShowCatAndJerryMenu()
        {
            DisplaySelection("Week 6 Assignment 2 [THE CAT AND JERRY]", new ApplicationPageEnumWrapper[]
            {
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Cat),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Jerry),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Back)
            });
        }
    }
}
