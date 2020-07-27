using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintnXnmatrix(n);
        }

        static void PrintnXnmatrix(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <=n; k++)
                {
                    Console.Write(n + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
