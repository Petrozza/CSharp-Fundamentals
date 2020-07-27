using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            int NumberOfSheets = int.Parse(Console.ReadLine());
            double singleSheetArea = double.Parse(Console.ReadLine());

            double BoxArea = side * side * 6;
            double paperCoverArea = NumberOfSheets * 1.0 * singleSheetArea;
            double minus = (NumberOfSheets / 3) * (0.75 * singleSheetArea);
            double total = paperCoverArea - minus;
            double percentge = total / BoxArea * 100;
            Console.WriteLine("You can cover {0:f2}% of the box.", percentge);
        }
    }
}
