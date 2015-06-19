using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a playing card (enter 0 for card #10):");
            char card = char.Parse(Console.ReadLine());

            if (card == '2')
            {
                Console.WriteLine("Valid card!");
            }
            else if (card == '3')
            {
                Console.WriteLine("Valid card!");
            }
            else if (card == '4')
            {
                Console.WriteLine("Valid card!");
            }
            else if (card == '5')
            {
                Console.WriteLine("Valid card!");
            }
            else if (card == '6')
            {
                Console.WriteLine("Valid card!");
            }
            else if (card == '7')
            {
                Console.WriteLine("Valid card!");
            }
            else if (card == '8')
            {
                Console.WriteLine("Valid card!");
            }
            else if (card == '9')
            {
                Console.WriteLine("Valid card!");
            }
            else if (card == '0')
            {
                Console.WriteLine("Valid card!");
            }
            else if (card == 'J')
            {
                Console.WriteLine("Valid card!");
            }
            else if (card == 'Q')
            {
                Console.WriteLine("Valid card!");
            }
            else if (card == 'K')
            {
                Console.WriteLine("Valid card!");
            }
            else if (card == 'A')
            {
                Console.WriteLine("Valid card!");
            }
            else
            {
                Console.WriteLine("Invalid card!");
            }
        }
    }
}