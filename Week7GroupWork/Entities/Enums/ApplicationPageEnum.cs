using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7GroupWork.Entities.Enums
{
    public enum ApplicationPageEnum
    {
        [Description("Launch App")]
        LaunchApp,
        [Description("Start")]
        Start,
        [Description("About")]
        About,
        [Description("Exit")]
        Exit,
        [Description("Week 6 Assignment 1")]
        W6A1,
        [Description("Week 6 Assignment 2")]
        W6A2,
        [Description("Week 6 Assignment 3")]
        W6A3,
        [Description("Week 6 Assignment 4")]
        W6A4,
        [Description("Back")]
        Back
    }
}
