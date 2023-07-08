using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Q_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the kolimeter value:");
            double kilometer = Convert.ToDouble(Console.ReadLine());
            ConvertValues converter = new ConvertValues();
            double meter = converter.KilometerTOMeter(kilometer);
            Console.WriteLine("The equivalent meter value is:" + meter);
            Console.ReadLine();
        }
    }
}
