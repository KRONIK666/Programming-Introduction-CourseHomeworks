using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassworkMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array's elements: ");
            int[,] Matrix = new int[4, 4];

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Your matrix is: ");
            Console.WriteLine();

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i,j] + " ");
                } Console.WriteLine();
            } Console.WriteLine();

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i,j] % 2 == 1 || Matrix[i,j] % 2 == -1)
                    {
                        Matrix[i, j] = Matrix[i, j] * 2;
                    } Console.Write(Matrix[i, j] + " ");
                } Console.WriteLine();
            } Console.WriteLine();
        }
    }
}