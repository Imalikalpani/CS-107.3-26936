using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Lab_question_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle:");
            string input = Console.ReadLine();
            double radius;
            while (!double.TryParse(input, out radius) || radius <= 0) ;
            {
                Console.WriteLine("Invalid input.Please enter a positive numeric value for the radius :");
                input = Console.ReadLine();

            }
                double area =Math.PI *Math.Pow(radius, 2);
            Console.WriteLine("The area of the circle is:" + area);
            Console.ReadLine();

                
        }
    }
}
