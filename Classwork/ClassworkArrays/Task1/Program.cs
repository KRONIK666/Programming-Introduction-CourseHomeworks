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
            int[] myArray = new int[] { 8, 4, 0, 5, 2, 1, 1, 7, 2, 5 };
            int[] myCopy = new int[myArray.Length];

            for (int num = 0; num < myArray.Length; num++)
            {
                myCopy[num] = myArray[num];
            }
            foreach (int num in myCopy)
            {
                Console.WriteLine(num);
            }
        }
    }
}