using System;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            
            double distance1 = DistanceFromZero(x1, y1);
            double distance2 = DistanceFromZero(x2, y2);
            
            if (distance1 <= distance2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            
            else if (distance2 < distance1)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        static double DistanceFromZero(double a, double b)
        {
            double distance = Math.Sqrt(a * a + b * b);
            return distance;

        }
    }
}
