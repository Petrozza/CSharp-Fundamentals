using System;
using System.Linq;
using System.Collections.Generic;

namespace Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] race = Console.ReadLine().Split().Select(int.Parse).ToArray();

            double car1 = 0;
            double car2 = 0;

            for (int i = 0; i < race.Length/2; i++)
            {
                car1 += race[i];
                car2 += race[race.Length - i - 1];

                if (race[i] == 0)
                {
                    car1 *= 0.8;
                }

                if (race[race.Length - i - 1] == 0) 
                {
                    car2 *= 0.8;
                }
            }
            if (car1 < car2)
            {
                Console.WriteLine($"The winner is left with total time: {Math.Round(car1, 1)}");
            }
            if (car2 < car1)
            {
                Console.WriteLine($"The winner is right with total time: {Math.Round(car2, 1)}");
            }

        }
    }
}
