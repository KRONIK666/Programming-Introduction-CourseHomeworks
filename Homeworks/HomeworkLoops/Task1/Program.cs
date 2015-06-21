using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter a number: ");

            for (int counter = 1; ; counter++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("This is The End!");
                    Console.WriteLine();
                    break;
                }
                {
                    sum = sum + number;
                    Console.WriteLine();
                    Console.WriteLine("Current sum: " + sum);
                    Console.Write("Enter a number: ");
                }
            }
        }
    }
}