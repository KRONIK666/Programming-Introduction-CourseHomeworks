using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassworkLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int m = 6;
            int sum = 1;

            for (int counter = 1; counter <= m; counter++)
            {
                sum = sum * n;
            }

            Console.WriteLine("N of grade M is: " + sum);
        }
    }
}