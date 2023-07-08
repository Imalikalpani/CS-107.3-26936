using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Q_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the  radius of the cicle:");
            double radius = Convert.ToDouble(Console.ReadLine());

            FindValues calculator = new FindValues();
            double area = calculator.FindArea(radius);
            double circumference = calculator.Findcircumference(radius);
            Console.WriteLine("The area of the circle is:" + area);
            Console.WriteLine("The circumference of the circle is :" + circumference);
            Console.ReadLine();

        }
    }
}
