using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededExperience = int.Parse(Console.ReadLine());
            int countOfBattles = int.Parse(Console.ReadLine());
            double sumEarnedExperience = 0;

            for (int i = 1; i <= countOfBattles; i++)
            {
                double earnedExperience = int.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    earnedExperience = earnedExperience * 1.15;
                }
                if (i % 5 == 0)
                {
                    earnedExperience = earnedExperience * 0.9;
                }
                sumEarnedExperience += earnedExperience;
                if (sumEarnedExperience >= neededExperience)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    break;
                }
            }
            if (sumEarnedExperience < neededExperience)
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExperience - sumEarnedExperience:f2} more needed.");
            }
        }
    }
}