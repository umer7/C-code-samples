using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            short a;
            int b;
            a = 10;
            b = 20;
            double c;
            c = a + b;
            Console.Write("a={0},b={1},c={2}", a, b, c);
            Console.Write("umer");

            if (a == c)
            {
                Console.WriteLine("a is equal to c");

            }
            else
                Console.WriteLine(" a is not equal to c");

            Console.WriteLine();
            char grade = 'B';
            switch(grade)
            {
                case 'A':
                    Console.WriteLine("A grade");
                    break;
                case 'B':
                    Console.WriteLine("B grade");
                    break;
                default:
                    Console.WriteLine("invalid grade");
                    break;
               


            }
            Console.ReadKey();
        }
    }
}
