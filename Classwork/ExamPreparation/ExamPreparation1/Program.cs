using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 8, 17, 28, 9, 10, 33, 16, 13, 24, 30 };

            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (i % 2 == 0 && myArray[i] > max)
                {
                    max = myArray[i];
                }
                if (i % 2 == 1 && myArray[i] < min)
                {
                    min = myArray[i];
                }
            }
            Console.WriteLine("Max number between even indexes: " + max);
            Console.WriteLine("Min number between odd indexes: " + min);
            Console.WriteLine();
        }
    }
}