using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.Entities.BaseEntities;
using Week7GroupWork.Services;
using Week7GroupWork.WrapperClasses.ApplicationClasses;

namespace Week7GroupWork.WrapperClasses
{
    public class Week6Assignment1Wrapper
    {
        Week6Assignment1 functionality;

        public Week6Assignment1Wrapper(Week6Assignment1 functionality)
        {
            this.functionality = functionality;
        }

        public void Run() => functionality.Run();
        public Shape[] Shapes { get => functionality.Shapes; set => functionality.Shapes = value; }
        
    }
}
