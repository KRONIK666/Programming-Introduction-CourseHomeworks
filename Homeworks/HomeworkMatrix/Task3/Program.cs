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
            Console.Write("Enter an integer for 'a': ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter an integer for 'b' that is bigger than 'a': ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            } Console.WriteLine();
        }
    }
}