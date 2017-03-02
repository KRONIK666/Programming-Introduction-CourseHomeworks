using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine();
            NameIt(name);
            Console.WriteLine();
        }

        private static void NameIt(string name)
        {
            Console.WriteLine("Greetings, " + name + "!");
        }
    }
}