using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a number: ");
            int n = int.Parse(Console.ReadLine());

            int x = 3;
            int y = 7;

            for (int counter = 1; counter <= n; counter++)
            {
                if (counter % x == 0 && counter % y == 0)
                {
                    continue;
                }
                Console.WriteLine(counter);
            }

            Console.WriteLine();
            Console.WriteLine("The End!");
        }
    }
}