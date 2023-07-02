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
            int number1, number2;
            Console.WriteLine("Please enter the number1:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please  enter the second number2:");
            number2 = Convert.ToInt32(Console.ReadLine());
            int sum;
            sum = number1 + number2;
            Console.WriteLine("The sum of two numbers:" + sum.ToString());
            Console.ReadLine();
        }
    }
}
