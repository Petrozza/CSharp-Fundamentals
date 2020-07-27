using System;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int countPlayers = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDayPerPerson = double.Parse(Console.ReadLine());
            double foodPerDayPerPerson = double.Parse(Console.ReadLine());

            double totalWater = days * countPlayers * waterPerDayPerPerson;
            double totalFood = days * countPlayers * foodPerDayPerPerson;

            for (int day = 1; day <= days; day++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                groupEnergy -= energyLoss;

                if (groupEnergy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
                    return;
                }

                if (day % 2 == 0)
                {
                    groupEnergy = groupEnergy + groupEnergy * 0.05;
                    totalWater = totalWater - totalWater * 0.30;
                }

                if (day % 3 == 0)
                {
                    groupEnergy = groupEnergy + groupEnergy * 0.10;
                    totalFood = totalFood - (totalFood / countPlayers);
                }
            }
            Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
        }
    }
}

