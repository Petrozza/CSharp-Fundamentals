using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = SumOfFirstDigits(a, b);
            int result = SubtractThirdDigit(sum, c);
            Console.WriteLine(result);
        }

        static int SumOfFirstDigits(int a, int b)
        {
            return a + b;
        }

        static int SubtractThirdDigit(int sum, int c)
        {
            return sum - c;
        }
    }
}
