using System;

namespace Task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            do
            {
                if (counter % 7 == 0 || counter % 11 == 0)
                {
                    Console.WriteLine(counter);
                }
                counter++;
            } while (counter <= 100);
        }
    }
}