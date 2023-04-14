//Mohamad Adnan Rezaei
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajme_jabe
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Tool ra vared konid : ");
            double L = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Arz ra vared konid : ");
            double W = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ertefa ra vared konid : ");
            double H = Convert.ToDouble(Console.ReadLine());
            double show = calc(L, W, H);
            Console.WriteLine("\nHajm ja'be = " + show);
        }
        private static double calc(double l, double w, double h)
        {
            double Result = l * w * h;
            return Result;
        }
    }
}
