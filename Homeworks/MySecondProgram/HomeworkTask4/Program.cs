using System;

namespace HomeworkTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int y = int.Parse(Console.ReadLine());

            int z = x % y;
            Console.WriteLine("Result: " + z);
        }
    }
}