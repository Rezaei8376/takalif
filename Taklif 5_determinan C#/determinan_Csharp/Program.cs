using System;

namespace determinan_Csharp
{
    class Takalif
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            int det;
            Console.WriteLine("Enter 9 integers for the matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[3, 3] = Convert.ToInt32(Console.ReadLine());
                }
            }

            det = arr[0, 0] * (arr[1, 1] * arr[2, 2] - arr[1, 2] * arr[2, 1])
                - arr[0, 1] * (arr[1, 0] * arr[2, 2] - arr[1, 2] * arr[2, 0])
                + arr[0, 2] * (arr[1, 0] * arr[2, 1] - arr[1, 1] * arr[2, 0]);
            Console.WriteLine("Determinant of the matrix = " + det);
        }
    }
}