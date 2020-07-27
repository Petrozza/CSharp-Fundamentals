using System;

namespace Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            double n2 = double.Parse(Console.ReadLine());
            double result = CalculateTwoNumbers(n1, n2, op);
            Console.WriteLine($"{Math.Round(result, 2)}");
        }

        static double CalculateTwoNumbers(double n1, double n2, string op)
        {
            double result = 0;
            switch (op)
            {
                case "/":
                    result = n1 / n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
            }
            return result;

        }
    }
}
