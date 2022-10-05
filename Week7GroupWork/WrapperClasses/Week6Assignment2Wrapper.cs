using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.WrapperClasses.ApplicationClasses;

namespace Week7GroupWork.WrapperClasses
{
    public class Week6Assignment2Wrapper
    {
        Week6Assignment2 catAndJerry;

        public Week6Assignment2Wrapper()
        {
            this.catAndJerry = new Week6Assignment2();
        }

        public Week6Assignment2Wrapper(Week6Assignment2 catAndJerry)
        {
            this.catAndJerry = catAndJerry;
        }

        public void Run()
        {
            catAndJerry.Run();
        }
    }
}
