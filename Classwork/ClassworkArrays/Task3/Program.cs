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
            int[] myArray = new int[] { 8, 4, 0, 5, 2, 2, 5, 0, 4, 8 };
            bool isSymetric = true;

            for (int num = 0; num < myArray.Length / 2; num++)
            {
                if (myArray[num] != myArray[myArray.Length - num - 1])
                {
                    isSymetric = false;
                }
                                
            }
            Console.WriteLine("Is symmetric? {0}", isSymetric);
        }
    }
}