using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Matrix = new int[,] {
            { 8, 17, 28, 9, 10, 33, 16, 13, 24, 30 },
            { 88, 2, 79, 95, 4, 14, 66, 3, 44, 6 }
            };

            int min = int.MaxValue;
            int max = int.MinValue;

            int ColMinIndex = 0;
            int RowMinIndex = 0;
            int ColMaxIndex = 0;
            int RowMaxIndex = 0;

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] < min)
                    {
                        min = Matrix[i, j];
                        ColMinIndex = i;
                        RowMinIndex = j;
                    }
                    if (Matrix[i, j] > max)
                    {
                        max = Matrix[i, j];
                        ColMaxIndex = i;
                        RowMaxIndex = j;
                    }
                }
            }
            Console.WriteLine("Min valued element is {0} with index [{1},{2}];", min, ColMinIndex, RowMinIndex);
            Console.WriteLine("Max valued element is {0} with index [{1},{2}];", max, ColMaxIndex, RowMaxIndex);
        }
    }
}