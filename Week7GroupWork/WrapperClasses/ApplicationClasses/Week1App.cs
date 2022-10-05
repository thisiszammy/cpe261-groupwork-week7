using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.Entities.BaseEntities;
using Week7GroupWork.Services;

namespace Week7GroupWork.WrapperClasses.ApplicationClasses
{

    public class Week1App
    {
        public class Number
        {
            public class Average
            {
                public double calculate(double a, double b, double c)
                {
                    return (a + b + c) / 3;
                }
            }
        }

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

        public void weekass3()
        {
            string First, Last;
            Box2();
            Console.Write("\t\t\t\tEnter First Name: ");
            First = Console.ReadLine();
            Console.Write("\t\t\t\tEnter Last Name: ");
            Last = Console.ReadLine();
            box(First, Last);
            int choice;
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Box4(First, Last);
                    double a, b, c, ave;
                    Console.Write("Enter First number: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Enter Second number: ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Enter Third number: ");
                    c = double.Parse(Console.ReadLine());
                    Number.Average mean = new Number.Average();
                    ave = mean.calculate(a, b, c);
                    Boxave(First, Last, ave);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Box3(First, Last);
                    double radius, rad;
                    Console.Write("Enter Radius: ");
                    radius = double.Parse(Console.ReadLine());
                    CircleWrapper.Circle circle = new CircleWrapper.Circle();
                    rad = circle.Area(radius);
                    Console.Clear();
                    Boxrad(First, Last, rad);
                    Console.ReadKey();
                    break;
            }
        }
        public void Box(string First, string Last)
        {
            Console.Write($@"                                                                                                                
                                                                                                                
                                                                                                                
                                                                                                                
                                                ░░░░                                                            
                                                                                                                
                                                                                                                
                ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
  ░░  ░░░░   ▒▒                         Welcome: {First} {Last}                          ▒▒    ░░    ░░        
        ░░    ▒▒                         Please Select an Option                          ▒▒          ░░        
              ▒▒                         1 - Find the average of 3 Numbers                ▒▒                    
              ▒▒                         2 - Find the area of a circle                    ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▓▓                    
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                    
                                                                                                                
                                              ░░    ░░                                                          
                                              ░░  ░░░░                                                          
                                                                                                                                                                                                         
");
        }

        internal void box(string First, string Last)
        {
            Console.Clear();
            Box(First, Last);
        }
        public void Box2()
        {
            Console.Write(@"                                                                                                                
                                                                                                                
                                                                                                                
                                                                                                                
                                                ░░░░                                                            
                                                                                                                
                                                                                                                
                ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
  ░░  ░░░░    ▒▒                               WELCOME PLEASE                             ▒▒    ░░    ░░        
        ░░    ▒▒                            PLEASE ENTER DETAILS                          ▒▒          ░░        
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▓▓                    
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                    
                                                                                                                
                                              ░░    ░░                                                          
                                              ░░  ░░░░                                                          
                                                                                                                                                                                                         
");
        }

        public void Box3(string First, string Last)
        {
            Console.Write($@"                                                                                                                
                                                                                                                
                                                                                                                
                                                                                                                
                                                ░░░░                                                            
                                                                                                                
                                                                                                                
                ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
  ░░  ░░░░   ▒▒                         Welcome: {First} {Last}                           ▒▒    ░░    ░░        
        ░░    ▒▒                         Solving for Area of Circle                       ▒▒          ░░        
              ▒▒                         Please Enter the Radius                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▓▓                    
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                    
                                                                                                                
                                              ░░    ░░                                                          
                                              ░░  ░░░░                                                          
                                                                                                                                                                                                         
");
        }
        public void Box4(string First, string Last)
        {
            Console.Write($@"                                                                                                                
                                                                                                                
                                                                                                                
                                                                                                                
                                                ░░░░                                                            
                                                                                                                
                                                                                                                
                ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
  ░░  ░░░░   ▒▒                         Welcome: {First} {Last}                           ▒▒    ░░    ░░        
        ░░    ▒▒                         Solving for Average of 3 Numbers                 ▒▒          ░░        
              ▒▒                         Please Enter 3 Numbers                           ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▓▓                    
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                    
                                                                                                                
                                              ░░    ░░                                                          
                                              ░░  ░░░░                                                          
                                                                                                                                                                                                         
");

        }
        public void Boxrad(string First, string Last, double rad)
        {
            Console.Write($@"                                                                                                                
                                                                                                                
                                                                                                                
                                                                                                                
                                                ░░░░                                                            
                                                                                                                
                                                                                                                
                ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
  ░░  ░░░░   ▒▒                       Congratulations: {First} {Last}                       ▒▒    ░░    ░░        
        ░░    ▒▒                      The area of the circle has been solved                 ▒▒          ░░        
              ▒▒                      The result is : {rad}                                    ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▓▓                    
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                    
                                                                                                                
                                              ░░    ░░                                                          
                                              ░░  ░░░░                                                          
                                                                                                                                                                                                         
");

        }
        public void Boxave(string First, string Last, double ave)
        {
            Console.Write($@"                                                                                                                
                                                                                                                
                                                                                                                
                                                                                                                
                                                ░░░░                                                            
                                                                                                                
                                                                                                                
                ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
  ░░  ░░░░   ▒▒                       Congratulations: {First} {Last}                                  ▒▒    ░░    ░░        
        ░░    ▒▒                      The average of 3 numbers has been solved                    ▒▒          ░░        
              ▒▒                      The result is : {ave}                               ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▒▒                    
              ▒▒                                                                          ▓▓                    
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                    
                                                                                                                
                                              ░░    ░░                                                          
                                              ░░  ░░░░                                                          
                                                                                                                                                                                                         
");

        }
    }
}
