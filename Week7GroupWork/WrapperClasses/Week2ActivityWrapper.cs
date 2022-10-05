using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.WrapperClasses.ApplicationClasses;

namespace Week7GroupWork.WrapperClasses
{
    public class Week2ActivityWrapper
    {
        Week2Activity functionality;

        public Week2ActivityWrapper()
        {
            this.functionality = new Week2Activity();
        }
        public void Run() => functionality.Run();
    }
}
