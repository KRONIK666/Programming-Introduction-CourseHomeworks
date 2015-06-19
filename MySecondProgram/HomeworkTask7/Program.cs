using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTask7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write down a word: ");
            string a = Console.ReadLine();

            Console.Write("Write down another word: ");
            string b = Console.ReadLine();

            Console.Write("The first word contains the second word: ");
            Console.WriteLine(a.Contains(b));
        }
    }
}