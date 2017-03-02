using System;

namespace Task7
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

            int result = (n - k);
            long fnk = 1;

            for (int counter = 1; counter <= result; counter++)
            {
                fnk *= counter;
            }
            Console.WriteLine("(N-K)! = " + fnk);
            Console.WriteLine();

            long total = (fn * fk) / fnk;
            Console.WriteLine("Total: " + total);
            Console.WriteLine();
        }
    }
}