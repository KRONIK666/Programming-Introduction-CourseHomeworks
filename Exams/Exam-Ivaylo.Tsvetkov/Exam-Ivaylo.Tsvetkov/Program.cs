using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Ivaylo.Tsvetkov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число в интервала от 2 до 9:");
            int n = int.Parse(Console.ReadLine());

            int[,] MyArray = new int[n, n];
            Console.WriteLine("Броят на необходимите елементи за попълване на масива е:" + MyArray.Length);

            int[] MyArray2 = new int[MyArray.Length];

            Console.WriteLine("Въведете числа, за да попълните масива:", MyArray.Length);

            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray2[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (int item in MyArray2)
            {
                sum += item;
            }
            Console.WriteLine("Сумата от всички въведени елементи в масива е:" + sum);

            int c = MyArray2[0];


            for (int i = 0; i < MyArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyArray.GetLength(1); j++)
                {
                    MyArray[i, j] = c++;
                }
            }
            Console.WriteLine("Матрицата от въведените числа е:");
            for (int i = 0; i < MyArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyArray.GetLength(1); j++)
                {
                    Console.Write("      " + MyArray[j, i]);
                }
                Console.WriteLine();
            }
        }
    }
}