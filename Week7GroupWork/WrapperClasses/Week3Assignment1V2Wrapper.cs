using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.WrapperClasses.ApplicationClasses;

namespace Week7GroupWork.WrapperClasses
{
    public class Week3Assignment1V2Wrapper
    {
        public Week3Assignment1_V2 Week3Ass1;
        public Week3Assignment1V2Wrapper(Week3Assignment1_V2 W1A3)
        {
            Week3Ass1 = W1A3;
        }
        public void Display()
        {
            Week3Ass1.Display();
        }
    }
}
