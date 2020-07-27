using System;

namespace _8._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(GetNumberOfPower(number, power));
        }

        static double GetNumberOfPower(double n, int pow)
        {
            double result = 0;
            result = Math.Pow(n, pow);
            return result;
        }
    }
}
