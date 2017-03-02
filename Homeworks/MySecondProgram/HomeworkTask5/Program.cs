using System;

namespace HomeworkTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down a word: ");
            string a = Console.ReadLine();

            Console.WriteLine("Write down another word: ");
            string b = Console.ReadLine();

            string text = a + "_" + b;
            Console.WriteLine("String: " + text);
        }
    }
}