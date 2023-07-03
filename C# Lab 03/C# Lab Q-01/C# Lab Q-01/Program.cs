using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Lab_Q_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter a number:");
            i = int.Parse(Console.ReadLine());
            if (i %2 ==0)
            {
                Console.WriteLine("Entered number is an even number ");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Entered number is an odd number");
                Console.ReadLine();
            }
        }
    }
}
