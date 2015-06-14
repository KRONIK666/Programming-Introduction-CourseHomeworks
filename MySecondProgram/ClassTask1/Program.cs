using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            string s = Console.ReadLine();
            int x = int.Parse(s);

            Console.Write("Enter a number: ");

            string t = Console.ReadLine();
            int y = int.Parse(t);

            int result = x + y;

            Console.Write("Sum: ");
            Console.WriteLine(result);

            Console.Write("Enter a number to multiply: ");

            string v = Console.ReadLine();
            int z = int.Parse(v);

            int result2 = (x + y) * z;

            Console.Write("Result of multiplication: ");
            Console.WriteLine(result2);
        }
    }
}
