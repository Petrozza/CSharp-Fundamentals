using System;

namespace Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fires = Console.ReadLine().Split("#");//"High = 150" "Low = 55" "Medium = 86"
            int water = int.Parse(Console.ReadLine());
            string[] cell = new string[3];
            Console.WriteLine("Cells:");
            int currentCell = 0;
            double effort = 0.0;
            double totalEffort = 0;
            int totalFire = 0;

            for (int i = 0; i < fires.Length; i++)
            {
                cell = fires[i].Split(" = "); //"High" "150"
                currentCell = int.Parse(cell[1]);
                string typeOfFire = cell[0];

                if (typeOfFire == "High" && (currentCell < 81 || currentCell > 125))
                {
                    continue;
                }
                else if (typeOfFire == "Medium" && (currentCell < 51 || currentCell > 80))
                {
                    continue;
                }
                else if (typeOfFire == "Low" && (currentCell < 1 || currentCell > 50))
                {
                    continue;
                }

                if (water < currentCell)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($" - {cell[1]}");
                    totalFire += currentCell;
                }
                water -= currentCell;
                effort = currentCell * 0.25;
                totalEffort += effort;
            }
            Console.WriteLine($"Effort: {totalEffort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}

