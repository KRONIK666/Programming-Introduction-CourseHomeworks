using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            float x = float.Parse(Console.ReadLine());

            float y = x / 3;
            Console.WriteLine("y = " + x + " / 3");
            Console.WriteLine("Result: " + y);
        }
    }
}
