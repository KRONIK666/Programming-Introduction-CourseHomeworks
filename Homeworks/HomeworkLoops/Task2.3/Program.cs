﻿using System;

namespace Task2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter <= 100; counter++)
            {
                if (counter % 7 == 0 || counter % 11 == 0)
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }
}