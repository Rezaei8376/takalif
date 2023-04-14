//Mohamad Adnan Rezaei
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majmoe_va_haselzarbe
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number : ");
            int X = Convert.ToInt32(Console.ReadLine());
            if (X % 2 == 0)
            {
                Console.WriteLine("\nAdad zoj ast ");
                even(X);
            }
            if (X % 2 == 1)
            {
                Console.WriteLine("\nAdad fard ast ");
                odd(X);
            }
        }
        private static void even(int x)
        {
            int sum = 0, zarb = 1;
            for (int i = 2; i <= x; i++)
            {
                sum += i;
                zarb *= i;
            }
            Console.WriteLine("majmoe = " + sum);
            Console.WriteLine("haselzarb = " + zarb);
        }
        private static void odd(int x)
        {
            int sum = 0, zarb = 1;
            for (int i = 1; i <= x; i++)
            {
                sum += i;
                zarb *= i;
            }
            Console.WriteLine("majmoe = " + sum);
            Console.WriteLine("haselzarb = " + zarb);
        }
    }
}
