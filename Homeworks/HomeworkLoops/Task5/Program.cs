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
            Console.WriteLine("Enter 3 numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int counter = 1;

            do
                {
                    if (a < b && a < c)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Lowest number: " + a);
                    }
                    else if (b < a && b < c)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Lowest number: " + b);
                    }
                    else if (c < a && c < b)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Lowest number: " + c);
                    }
                    if (a > b && a > c)
                    {
                        Console.WriteLine("Highest number: " + a);
                        Console.WriteLine();
                    }
                    else if (b > a && b > c)
                    {
                        Console.WriteLine("Highest number: " + b);
                        Console.WriteLine();
                    }
                    else if (c > a && c > b)
                    {
                        Console.WriteLine("Highest number: " + c);
                        Console.WriteLine();
                    } counter++;
            } while (counter <= 1);
        }
    }
}