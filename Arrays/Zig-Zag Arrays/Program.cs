using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] row1 = new int[n];
            int[] row2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    row1[i] = line[0];
                    row2[i] = line[1];
                }
                else
                {
                    row1[i] = line[1];
                    row2[i] = line[0];
                }
            }
            Console.WriteLine(string.Join(" ", row1));
            Console.WriteLine(string.Join(" ", row2));
        }
    }
}
