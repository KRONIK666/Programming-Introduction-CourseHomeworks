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
            Console.Write("Enter length of myArray: ");
            int n = int.Parse(Console.ReadLine());
            int m = n * n;
            int[] myArray = new int[m];

            if (n >= 2 && n <= 9)
            {
                Console.WriteLine();
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write("Enter an element: ");
                    myArray[i] = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Start again! Please, enter a valid value!");
                Console.WriteLine();
                return;
            }

            Console.WriteLine("---------------");
            Console.WriteLine("myArray is:");
            Console.WriteLine();

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }

            int sum = 0;
            
            foreach (var item in myArray)
                {
                    sum = item + sum;
                }

            Console.WriteLine();
            Console.WriteLine("Sum of all elements in myArray: " + sum);

            int[,] Matrix = new int[n,n];

            Console.WriteLine("---------------");
            Console.WriteLine("Your Matrix is:");
            Console.WriteLine();

            int l = 0;

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[j, i] = myArray[l++];
                }
            }

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                } Console.WriteLine();
            } Console.WriteLine();
        }
    }
}