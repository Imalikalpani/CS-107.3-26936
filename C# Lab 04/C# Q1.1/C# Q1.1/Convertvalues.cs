using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Q1._1
{
    internal class Convertvalues
    {
        public void KilometerToMeter()
        {
            Console.WriteLine("Enter the kilometer value :");
            double kilometer = Convert.ToDouble(Console.ReadLine());
            double meter = kilometer * 1000;
            Console.WriteLine("The equivalent meter value is :" + meter);
        }
    }
}
