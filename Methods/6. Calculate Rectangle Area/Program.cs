using System;

namespace _6._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(GetRectangularArea(width, height));
        }

        static double GetRectangularArea(double w,  double h)
        {

            double area = w * h;
            return area;
        }
    }
}
