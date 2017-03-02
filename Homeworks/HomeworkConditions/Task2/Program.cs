using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Bonus points:");
            int Bonus = int.Parse(Console.ReadLine());

            if (Bonus >= 1 && Bonus <= 9)
            {
                if (Bonus >= 1 && Bonus <= 3)
                {
                    Console.Write("Total Bonus points: ");
                    Console.WriteLine(Bonus * 5);
                }
                else if (Bonus >= 4 && Bonus <= 6)
                {
                    Console.Write("Total Bonus points: ");
                    Console.WriteLine(Bonus * 10);
                }
                else if (Bonus >= 7 && Bonus <= 9)
                {
                    Console.Write("Total Bonus points: ");
                    Console.WriteLine(Bonus * 50);
                }
            }
            else
            {
                Console.WriteLine("Extreme Bonus points gained! Next Level!");
            }
        }
    }
}