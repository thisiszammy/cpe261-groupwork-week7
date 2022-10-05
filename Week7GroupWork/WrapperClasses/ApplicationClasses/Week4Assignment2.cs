using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.Entities;

namespace Week7GroupWork.WrapperClasses.ApplicationClasses
{
    public class Week4Assignment2
    {
        public void Run()
        {
            Console.WriteLine("\t______________________________________________");
            Console.WriteLine("\tBelow Student's Grade\n");
            Student totalmark = new Student();
            totalmark.GetGrade();
            totalmark.showdetails();
            totalmark.PassOrFail();

            Console.WriteLine("\t______________________________________________");
            Console.WriteLine("\tBelow Calculates Hourly pay\n");
            Worker pay = new Worker();
            pay.calhrlywage();
            Console.WriteLine("\tEnter to exit...");
        }
        
        public Week4Assignment2()
        {
            
        }
    }
    //git add *
    //git commit 
    //git push
}
