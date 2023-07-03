using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Lab_Q__03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            string vowel = "aeiou";
            int cnt = 0;
            foreach (char ch in sentence)
            {
                if (vowel.Contains(ch.ToString())) ;
                {
                    cnt++;
                }

            }
            Console.WriteLine(cnt);

        }
    }
}
