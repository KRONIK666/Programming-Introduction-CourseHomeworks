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
            Console.WriteLine("Please, enter a playing card:");
            string card = (Console.ReadLine());

            switch (card)
                {
                    case "2":
                        Console.WriteLine("Valid card!");
                        break;
                    case "3":
                        Console.WriteLine("Valid card!");
                        break;
                    case "4":
                        Console.WriteLine("Valid card!");
                        break;
                    case "5":
                        Console.WriteLine("Valid card!");
                        break;
                    case "6":
                        Console.WriteLine("Valid card!");
                        break;
                    case "7":
                        Console.WriteLine("Valid card!");
                        break;
                    case "8":
                        Console.WriteLine("Valid card!");
                        break;
                    case "9":
                        Console.WriteLine("Valid card!");
                        break;
                    case "10":
                        Console.WriteLine("Valid card!");
                        break;
                    case "J":
                        Console.WriteLine("Valid card!");
                        break;
                    case "Q":
                        Console.WriteLine("Valid card!");
                        break;
                    case "K":
                        Console.WriteLine("Valid card!");
                        break;
                    case "A":
                        Console.WriteLine("Valid card!");
                        break;
                    default:
                        Console.WriteLine("Invalid card!");
                        break;
                }
        }
    }
}