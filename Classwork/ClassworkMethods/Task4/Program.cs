using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int n = int.Parse(Console.ReadLine());
            string[] massive = new string[n];

            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write("Enter element: ");
                massive[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Your array is:");
            Console.WriteLine();

            BuildArray(massive);

            Console.WriteLine();
        }

        private static void BuildArray(string[] massive)
        {
            for (int i = massive.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(massive[i]);
            }
        }
    }
}