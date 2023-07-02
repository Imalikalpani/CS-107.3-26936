using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___Lab_question_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double circumference;
            Console.WriteLine("Enter the value of radius:");
            radius = double.Parse(Console.ReadLine());
            circumference = 2 * Math.PI * radius;
            Console.WriteLine("Circumference:" + Math.Round(circumference, 2));


        }
    }
}
