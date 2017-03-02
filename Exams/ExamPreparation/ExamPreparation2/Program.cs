using System;

namespace ExamPreparation2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayOne = new int[] { 3, 5, 8, 11, 15, 13, 18, 22, 33, 0 };
            int[] ArrayTwo = new int[] { 8, 2, 5, 33, 22, 3, 12, 5, 9, 0 };

            Console.WriteLine("Same elements in both arrays:");
            Console.WriteLine();

            for (int i = 0; i < ArrayOne.Length; i++)
            {
                for (int j = 0; j < ArrayTwo.Length; j++)
                {
                    if (ArrayOne[i] == ArrayTwo[j])
                    {
                        Console.WriteLine(ArrayOne[i]);
                        break;
                    }
                }
            } Console.WriteLine();
        }
    }
}