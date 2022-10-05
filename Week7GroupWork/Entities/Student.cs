using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week7GroupWork.Entities
{
    public class Student : Human
    {
        private double grade;
        public Student()
        {
            
        }
        public void showdetails()
        {
            Console.WriteLine("\n\tThe student's Grade is {0}",this.Grade);
        }
        public void GetGrade() 
        { 
            Console.Write("\tEnter Student's Grade (5.0 - 1.0): "); 
            Grade = double.Parse(Console.ReadLine()); 
        }
        public void PassOrFail()
        {
            if (Grade < 3.0)
            {
                Console.WriteLine("\t{0} {1} Failed\n",FirstName,LastName);

            }
            else Console.WriteLine("\t{0} {1} Passed\n", FirstName, LastName);
        }
        public Student(string firstName,string lastName, double grade) 
            : base(firstName, lastName)
        {
            this.grade = grade;
        }
      
        

        public double Grade { get => grade; set => grade = value; }
    }
}
