using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7GroupWork.Entities
{

    public class Worker:Human
    {
        private double wage;
        private double hrsworked;
        private double hourlyPay;
        public Worker()
        {

        }
        public Worker(string FirstName, string LastName) : base(FirstName, LastName)
        {
        }

        public double Wage { get => wage; set => wage = value; }
        public double Hrsworked { get => hrsworked; set => hrsworked = value; }
        public double HourlyPay { get => hourlyPay; set => hourlyPay = value; }
       
        public void calhrlywage()
        {
            Console.Write("\tEnter Minimum Wage (in Pesos): ");
            Wage = double.Parse(Console.ReadLine());

            Console.Write("\tEnter Hours Worked of the Employee: ");
            Hrsworked = double.Parse(Console.ReadLine());

            HourlyPay = Wage / Hrsworked;
            Console.WriteLine("\tThe Hourly Pay of {0} {1} is Php {2}", FirstName, LastName, HourlyPay);
        }
    }
}
