using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int digits = Math.Abs(int.Parse(Console.ReadLine()));
            int multiply = GetSumOfEvenDigits(digits) * GetSumOfOddDigits(digits);
            Console.WriteLine(multiply);
        }

        static int GetSumOfEvenDigits(int digits)
        {
            string digString = digits.ToString();
            int sum = 0;
            for (int i = 0; i < digString.Length; i++)
            {
                int digit = int.Parse(digString[i].ToString());
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
            }
            return sum;
        }

        static int GetSumOfOddDigits(int digits)
        {
            string digString = digits.ToString();
            int sum = 0;
            for (int i = 0; i < digString.Length; i++)
            {
                int digit = int.Parse(digString[i].ToString());
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
            }
            return sum;
        }
    }
}
