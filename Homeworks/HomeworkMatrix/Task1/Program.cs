using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Matrix = new int[,] {
                {84, 15, 21, 17, 25, 31},
                {12, 16, 18, 10, 12, 14},
                {11, 15, 16, 15, 16, 21},
                {22, 33, 44, 55, 66, 77},
                {17, 15, 13, 11, 10, 20},
                {21, 31, 22, 32, 41, 42}
            };

            Console.WriteLine("Original Matrix:");
            Console.WriteLine();

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                } Console.WriteLine();
            } Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Even numbers in Matrix:");
            Console.WriteLine();

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] % 2 == 1)
                    {
                        continue;
                    } Console.Write(Matrix[i, j] + " ");
                }
            } Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}