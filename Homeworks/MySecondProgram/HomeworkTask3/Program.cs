using System;

namespace HomeworkTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count the area of a triangle?");

            Console.WriteLine("Enter 'a': ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 'h': ");
            int h = int.Parse(Console.ReadLine());

            float area = a * h / 2f;
            Console.WriteLine("The area of the triangle is: " + area);
        }
    }
}