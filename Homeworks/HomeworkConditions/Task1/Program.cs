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
            Console.WriteLine("Enter a town from Top 10 towns by population in Bulgaria:");
            int town = int.Parse(Console.ReadLine());

            if (town >= 0 && town <= 9)
            {
                switch (town)
                {
                    case 0:
                        Console.WriteLine("Sofia");
                        break;
                    case 1:
                        Console.WriteLine("Plovdiv");
                        break;
                    case 2:
                        Console.WriteLine("Varna");
                        break;
                    case 3:
                        Console.WriteLine("Burgas");
                        break;
                    case 4:
                        Console.WriteLine("Ruse");
                        break;
                    case 5:
                        Console.WriteLine("Stara Zagora");
                        break;
                    case 6:
                        Console.WriteLine("Pleven");
                        break;
                    case 7:
                        Console.WriteLine("Dobrich");
                        break;
                    case 8:
                        Console.WriteLine("Sliven");
                        break;
                    case 9:
                        Console.WriteLine("Shumen");
                        break;
                }
            }
            else
            {
                Console.WriteLine("No such town in Top 10!");
            }
        }
    }
}