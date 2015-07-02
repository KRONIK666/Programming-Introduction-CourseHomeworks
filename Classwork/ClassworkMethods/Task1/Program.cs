using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter Y: ");
            int y = int.Parse(Console.ReadLine());

            SumIt(x,y);
        }

        private static void SumIt(int x, int y)
        {
            int sum = x + y;

            Console.WriteLine();
            Console.WriteLine("x + y = " + sum);
            Console.WriteLine();
        }
    }
}