using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int numInt = int.Parse(Console.ReadLine());

            if (numInt >= 1 && numInt <= 5)
            {
                if (numInt % 2 == 0)
                {
                    Console.WriteLine("The number is even!");
                }
                else
                {
                    Console.WriteLine("The number is odd!");
                }
            }
            else if (numInt >= 6 && numInt <= 15)
            {
                if (numInt % 3 == 0)
                {
                    Console.WriteLine("True!");
                }
                else
                {
                    Console.WriteLine("False!");
                }
            }
            else
            {
                if (numInt > 0)
                {
                    Console.WriteLine("Number is Positive!");
                }
                else if (numInt < 0)
                {
                    Console.WriteLine("Number is Negative!");
                }
                else if (numInt == 0)
                {
                    Console.WriteLine("Number is Zero!");
                }
            }
        }
    }
}