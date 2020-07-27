using System;

namespace Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            IsNegative(a, b, c);
        }

        static void IsNegative(int a, int b, int c)
        {
            int[] numbers = { a, b, c };

            int count = 0;
            for (int i = 0; i <= 2; i++)
            {
                if (numbers[i] == 0)
                {
                    Console.WriteLine("zero");
                    return;
                }
                else if (numbers[i] < 0)
                {
                    count++;
                }
            }
            if (count %2 != 0)
            {
                Console.WriteLine("negative");
            }

            else
            {
                Console.WriteLine("positive");
            }

        }
    }
}
