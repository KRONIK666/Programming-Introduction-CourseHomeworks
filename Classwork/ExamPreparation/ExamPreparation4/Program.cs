using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            int b = int.Parse(Console.ReadLine());
            int c = 0;
            Console.WriteLine();

            if (a > b)
            {
                c = a;
                a = b;
                b = c;
                Console.WriteLine("New value for a: " + a);
                Console.WriteLine("New value for b: " + b);
            }
            else
            {
                Console.WriteLine("Cannot switch numbers!");
            }
            Console.WriteLine();
        }
    }
}