using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Lab_question_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f;
            Console.WriteLine("Enter the first number:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number:");
            b = Convert.ToDouble(Console.ReadLine());
            c = a + b;
            d = a - b;
            e = a * b;
            f = a / b;

            Console.WriteLine("Addition:" + c);
            Console.WriteLine("Subtraction:" + d);
            Console.WriteLine("Multiplication:" + e);
            Console.WriteLine("division :" + f);
            Console.ReadKey();


        }
    }
}
