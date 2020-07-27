using System;

namespace Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            bool isPrecision = false;

            decimal eps = Math.Round((decimal)Math.Abs(a - b), 8);
            if (eps >= (decimal)0.000001)
            {
                isPrecision = false;
            }
            else if (eps < (decimal)0.000001)
            {
                isPrecision = true;
            }
            Console.WriteLine(isPrecision);
        }
    }
}
