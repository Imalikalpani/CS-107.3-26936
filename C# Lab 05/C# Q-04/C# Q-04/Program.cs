using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Q_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Separateclass sparateobj = new Separateclass();
            separateobj.SayHello; //ERROR
            /* In this code the ,'sayHello()' method in the separateclas is declared as 'private'.A
             * 'private' member can only be accessed within the same class where it is defined. To access the 'sayHello()' method from the main class,it needs to be declared as'public'.*/

            Console.ReadLine();
        }
    }
}
