﻿using System;

namespace HomeworkTask8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word with a lenght of at least 6 letters: ");
            string word = Console.ReadLine();

            Console.Write("The 4th letter is: ");
            Console.WriteLine(word[3]);
        }
    }
}