using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            double stepLenght = float.Parse(Console.ReadLine()) / 100;
            int distanceNeeded = int.Parse(Console.ReadLine());
            double distanceMade = steps * stepLenght;
            double minus = (steps / 5) * (stepLenght * 0.3);
            double total = distanceMade - minus;
            double percentage = total / distanceNeeded * 1.0 * 100;
            Console.WriteLine($"You travelled {percentage:f2}% of the distance!");
        }

    }
}