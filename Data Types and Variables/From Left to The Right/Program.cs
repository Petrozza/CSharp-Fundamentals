using System;
using System.Diagnostics.CodeAnalysis;

namespace From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                string[] numbers = input.Split();

                long left = long.Parse(numbers[0]);
                long right = long.Parse(numbers[1]);

                long sumLeft = 0;
                long leftDigit = left;
                while (leftDigit != 0)
                {
                    sumLeft += leftDigit % 10;
                    leftDigit /= 10L;
                }

                long sumRight = 0;
                long rightDigit = right;
                while (rightDigit != 0)
                {
                    sumRight += rightDigit % 10;
                    rightDigit /= 10;
                }

                if (left > right)
                {
                    Console.WriteLine(Math.Abs(sumLeft));
                }
                else
                {
                    Console.WriteLine(Math.Abs(sumRight));
                }
            }

        }
    }
}
