using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            float expectedPlunder = float.Parse(Console.ReadLine());
            float totalPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                totalPlunder += dailyPlunder;
                totalPlunder = PlunderEvery3Day(i, totalPlunder, dailyPlunder);
                totalPlunder = PlunderEvery5Dy(i, totalPlunder);
            }
            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                double percentge = totalPlunder / expectedPlunder * 100;
                Console.WriteLine($"Collected only {percentge:f2}% of the plunder.");
            }
        }
        static float PlunderEvery3Day(int i, float totalPlunder, int dailyPlunder)
        {
            if (i % 3 == 0)
            {
                totalPlunder += dailyPlunder * 0.5F;
            }
            return totalPlunder;
        }

        static float PlunderEvery5Dy(int i, float totalPlunder)
        {
            if (i % 5 == 0)
            {
                totalPlunder -= totalPlunder * 0.30F;
            }
            return totalPlunder;
        }
    }
}
