using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array's length: ");
            int n = int.Parse(Console.ReadLine());

            int[] myArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter next element: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    sum = myArray[i] + sum;
                }
            } Console.WriteLine();
            Console.WriteLine("Sum of even elements: " + sum);
            Console.WriteLine();
        }
    }
}