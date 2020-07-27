using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            PrintSmallestNumber(a, b, c);
        }

        static void PrintSmallestNumber(int a, int b, int c)
        {
            int result = Math.Min(a, Math.Min(b, c));
            Console.WriteLine(result);
        }
    }
}
