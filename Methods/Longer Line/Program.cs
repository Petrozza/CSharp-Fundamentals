using System;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            GetLineLenght(x1, y1, x2, y2, x3, y3, x4, y4);

        }

        static void GetLineLenght(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double line1Lenght = Math.Sqrt((Math.Abs((x2 - x1)) * Math.Abs((x2 - x1))) + Math.Abs(((y2 - y1)) * Math.Abs((y2 - y1))));
            double line2Lenght = Math.Sqrt((Math.Abs((x4 - x3)) * Math.Abs((x4 - x3))) + Math.Abs(((y4 - y3)) * Math.Abs((y4 - y3))));

            if (line1Lenght >= line2Lenght)
            {
                DistanceFromCenter(x1, y1, x2, y2);
            }
            else
            {
                DistanceFromCenter(x3, y3, x4, y4);
            }
        }

        static void DistanceFromCenter(double a, double b, double c, double d)
        {
            double distance1Point = Math.Sqrt((a * a) + (b * b));
            double distance2Point = Math.Sqrt((c * c) + (d * d));
            if (distance1Point > distance2Point)
            {
                Console.WriteLine($"({c}, {d})({a}, {b})");
                
            }
            else
            {
                Console.WriteLine($"({a}, {b})({c}, {d})");
            }

        }
    }
}
