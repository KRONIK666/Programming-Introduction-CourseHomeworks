﻿using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 8, 4, 0, 5, 2, 1, 1, 7, 2, 5 };
            int temp;

            for (int num = 0; num < myArray.Length / 2; num++)
            {
                temp = myArray[num];
                myArray[num] = myArray[myArray.Length - num - 1];
                myArray[myArray.Length - num - 1] = temp;
            }
            for (int num = 0; num < myArray.Length; num++)
            {
                Console.WriteLine(" " + myArray[num]);
            }
            Console.WriteLine();
        }
    }
}