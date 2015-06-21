using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            long fn = 1;

            for (int counter = 1; counter <= n; counter++)
            {
                fn *= counter;
            }
            Console.WriteLine("{0}! = {1}", n, fn);

            int k = 3;
            long fk = 1;

            for (int counter = 1; counter <= k; counter++)
            {
                fk *= counter;
            }
            Console.WriteLine("{0}! = {1}", k, fk);

            long result = (fn / fk);
            Console.WriteLine();
            Console.WriteLine("8! / 3! = " + result);
            Console.WriteLine();
        }
    }
}