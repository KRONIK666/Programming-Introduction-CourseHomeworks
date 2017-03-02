using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Enter a number: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter a number: ");
                int y = int.Parse(Console.ReadLine());
                Console.Write("Enter a number: ");
                int z = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Result: " + CalculateResult(x, y, z));
                Console.WriteLine();
            }
        }

        private static int CalculateResult(int x, int y, int z)
        {
            int result = x * y * z;
            return result;
        }
    }
}