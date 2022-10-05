using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.WrapperClasses.ApplicationClasses;

namespace Week7GroupWork.WrapperClasses
{
    public class Week3Assignment1Wrapper
    {
        private Week3Assignment1 POL;
        public Week3Assignment1Wrapper()
        {
            POL = new Week3Assignment1();
        }
        public Week3Assignment1Wrapper(Week3Assignment1 pOL)
        {
            POL = pOL;
        }
        public void callPol()
        {
            Console.Clear();
            POL.Main();
        }
    }
}
