using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count the area of a triangle?");

            Console.WriteLine("Enter a and h: ");

            int a = int.Parse(Console.ReadLine());

            int h = int.Parse(Console.ReadLine());

            int area = (a * h);

            Console.WriteLine("The area of the triangle is " + area);
        }
    }
}
