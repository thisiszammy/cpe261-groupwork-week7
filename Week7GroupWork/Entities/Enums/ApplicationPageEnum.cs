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
        [Description("Assignment 3")]
        ASS3,
        [Description("Week 2 Activity")]
        W2Act,
        [Description("Week 3 Assignment 1")]
        W3A1,
        [Description("Week 3 Assignment 1 V2")]
        W4A1,
        [Description("Week 4 Assignment 2")]
        W4A2,
        [Description("Week 6 Assignment 1")]
        W6A1,
        [Description("Week 6 Assignment 2")]
        W6A2,
        [Description("Cat")]
        Cat,
        [Description("Jerry")]
        Jerry,
        [Description("Run")]
        Run,
        [Description("Name Your Cat")]
        NameYourCat,
        [Description("Retreat")]
        Retreat,
        [Description("Calculate Velocity")]
        CalculateVelocity,
        [Description("Eat")]
        Eat,
        [Description("Drink")]
        Drink,
        [Description("Back")]
        Back,
    }
}
