using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Lab_Question_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the employee's salary:");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the tax (%):");
            double taxRate = double.Parse(Console.ReadLine());
            double salaryAfterTax = salary - (salary - (taxRate / 100));
            Console.WriteLine("Salary after tax :" + salaryAfterTax);
            Console.ReadLine();
        }
    }
}
