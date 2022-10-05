using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7GroupWork.WrapperClasses.ApplicationClasses
{
    internal class Week2Activity
    {
        public void Run()
        {
            int n, j = 1;
            double ave = 0, sum = 0;
            Console.WriteLine("How many numbers would you like to store in an array?");
            n = int.Parse(Console.ReadLine());
            int[] arryNum = new int[n];
            Console.WriteLine("Input {0} elements in the array:", n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Element {0}: ", j);
                arryNum[i] = int.Parse(Console.ReadLine());
                sum += arryNum[i];
                j++;
            }
            ave = sum / n;
            Console.Write("Elements of array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arryNum[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Sum = {0}", sum);
            Console.Write("Average = {0:F3}", Math.Round(ave, 3));
            Console.ReadKey();
        }
        internal void Main()
        {
            throw new NotImplementedException();
        }
    }
}