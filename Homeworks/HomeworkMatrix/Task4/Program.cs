using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Matrix = new int[5,6];

            Console.WriteLine("Your Matrix is: ");
            Console.WriteLine();

            int sum = 31;

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    sum = sum - 1;
                    Console.Write(sum + "\t");
                } Console.WriteLine();
            } Console.WriteLine();
        }
    }
}