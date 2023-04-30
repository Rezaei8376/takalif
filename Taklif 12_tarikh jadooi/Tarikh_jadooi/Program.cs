using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Rooz Ra vared Konid : ");
            int D = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maah Ra vared Konid : ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saal Ra vared Konid : ");
            int Y = Convert.ToInt32(Console.ReadLine());
            jadooi(D, M, Y);
        }
        private static void jadooi(int d, int m, int y)
        {
            int f = y % 100;
            int c = d * m;
            if (f == c)
                Console.WriteLine("* Tarikh jadooi ast *");
            else
                Console.WriteLine("! Tarikh jadooi nist !");
        }
    }
}
