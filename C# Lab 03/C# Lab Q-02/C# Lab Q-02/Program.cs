using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Lab_Q_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine());
            int sum = 0, remainder;
            while(number>0)
            {
                remainder = number % 10;
                sum = sum + remainder;
                number = number / 10;
            }
            Console.WriteLine("The sum of digits is :"+sum );
            Console.ReadKey();
        }
    }
}
