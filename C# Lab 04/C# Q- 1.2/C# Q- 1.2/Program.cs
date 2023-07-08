using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Q__1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the kilometer value :");
            double kilometer = Convert.ToDouble(Console.ReadLine());
            Convertvalues  converter = new Convertvalues();
            converter.kilometerTometer(kilometer);
            Console.ReadLine();


        }
    }
}
