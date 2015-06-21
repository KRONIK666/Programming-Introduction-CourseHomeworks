using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            while (counter <= 100)
            {
                if (counter % 7 == 0 || counter % 11 == 0)
                {
                    Console.WriteLine(counter);
                }
                counter++;
            }
        }
    }
}