//Mohamad Adnan Rezaei
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pow_x_2__2x_4
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("x^2 + 2x - 4\n");
            Console.WriteLine("Enter a number : ");
            int X = Convert.ToInt32(Console.ReadLine());
            calc(X);
        }
        private static void calc(int x)
        {
            double Result = (Math.Pow(x, 2)) + (x * 2) - 4;
            Console.WriteLine("\n" + Result);
        }
    }
}
