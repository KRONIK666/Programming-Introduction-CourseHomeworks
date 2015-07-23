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
            int[] myArray = new int[] { 8, 4, 0, 5, 5, 0, 4, 8 };
            bool symetric = true;

            for (int num = 0; num < myArray.Length / 2; num++)
            {
                if (myArray[num] != myArray[myArray.Length - num - 1])
                {
                    symetric = false;
                }
            }
            Console.WriteLine("Is myArray symetric? - {0}", symetric);
            Console.WriteLine();
        }
    }
}