using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.WrapperClasses.ApplicationClasses;

namespace Week7GroupWork.WrapperClasses
{
    public class Week4Assignment2Wrapper
    {
        private Week4Assignment2 Alren;

        public Week4Assignment2Wrapper(Week4Assignment2 alren)
        {
            Alren = alren;
        }
        public void Access()
        {
            Console.Clear();
            Alren.Run();
            Console.ReadKey();
        }

    }
   
}
