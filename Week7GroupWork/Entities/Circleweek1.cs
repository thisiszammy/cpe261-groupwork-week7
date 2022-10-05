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
    public class CircleWrapper
    {
        public class Circle
        {
            public double Area(double radius)
            {
                double area;
                area = radius * radius * Math.PI;
                return area;
            }
        }
    }
}


