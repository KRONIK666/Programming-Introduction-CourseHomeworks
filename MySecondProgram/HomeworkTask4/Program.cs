using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            float x = float.Parse(Console.ReadLine());

            Console.Write("Enter a number: ");
            float y = float.Parse(Console.ReadLine());

            float z = x % y;
            Console.WriteLine("Result: " + z);
        }
    }
}
