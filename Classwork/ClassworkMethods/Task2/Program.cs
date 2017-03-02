using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter Y: ");
            int y = int.Parse(Console.ReadLine());

            int sum = SumIt(x, y);
            Console.WriteLine();
            Console.WriteLine("x + y = " + sum);
            Console.WriteLine();
        }

        private static int SumIt(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
    }
}