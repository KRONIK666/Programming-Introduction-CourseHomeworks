using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 8, 17, 28, 9, 10, 33, 16, 13, 24, 30 };

            int min = int.MaxValue;
            int max = int.MinValue;
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (i % 2 == 0 && myArray[i] > max)
                {
                    max = myArray[i];
                    maxIndex = i;
                }
                if (i % 2 == 1 && myArray[i] < min)
                {
                    min = myArray[i];
                    minIndex = i;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}