using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int numInt = int.Parse(Console.ReadLine());

            if (numInt >= 1 && numInt <= 5)
            {
                if (numInt % 2 == 0)
                {
                    Console.WriteLine("The number is even!");
                }
                else
                {
                    Console.WriteLine("The number is odd!");
                }
            }
            else if (numInt >= 6 && numInt <= 15)
            {
                if (numInt % 3 == 0)
                {
                    Console.WriteLine("Дели се на 3 без остатък");
                }
                else
                {
                    Console.WriteLine("Не се дели на 3 без остатък");
                }
            }
            else
            {
                if (numInt > 0)
                {
                    Console.WriteLine("Числото е по-голямо от 0");
                }
                else if (numInt < 0)
                {
                    Console.WriteLine("Числото е по-малко от 0");
                }
                else if (numInt == 0)
                {
                    Console.WriteLine("Числото е равно на 0");
                }
            }
        }
    }
}
