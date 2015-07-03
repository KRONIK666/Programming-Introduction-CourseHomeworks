using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Symmetric numbers between 10 and 999 are:");
            Console.WriteLine();

            for (int i = 10; i <= 999; i++)
            {
                Symmetric(i);
            }
            Console.WriteLine();
        }

        private static void Symmetric(int i)
        {
            if (i % 11 == 0 && i <= 100)
            {
                Console.WriteLine(i);
            }
            if (i % 101 == 0)
                {
                    Console.WriteLine(i);
                }
            if (i % 111 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}