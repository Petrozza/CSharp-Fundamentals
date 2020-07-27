using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            decimal result = CalculateFactorial(a) / CalculateFactorial(b);
            Console.WriteLine($"{result:f2}");
        }

        static decimal CalculateFactorial(int a)
        {
            decimal factorial = 1;
            for (int i = 1; i <= a; i++)
            {
                factorial *= i;
            }
            return factorial;

        } 
    }
}
