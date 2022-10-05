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
    public class Week1AppWrapper
    {
        private Week1App App1Week;
        public Week1AppWrapper(Week1App app1Week)
        {
            App1Week1 = app1Week;
        }
        public Week1App App1Week1 { get => App1Week; set => App1Week = value; }
        public void weekass3()
        {
            App1Week.weekass3();
        }
    }
}
