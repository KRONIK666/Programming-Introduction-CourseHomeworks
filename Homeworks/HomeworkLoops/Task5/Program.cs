using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 numbers:");

            int lowest = 0;
            int highest = 0;

            for (int counter = 1; counter <= 10; counter++)
            {
                Console.Write("Number {0}: ", counter);
                int number = int.Parse(Console.ReadLine());

                if (counter == 1)
                {
                    lowest = number;
                    highest = number;
                }
                else
                {
                    if (number < lowest)
                    {
                        lowest = number;
                    }
                    else if (number > highest)
                    {
                        highest = number;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Lowest number: {0}", lowest);
            Console.WriteLine("Highest number: {0}", highest);
            Console.WriteLine();
        }
    }
}