using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirates = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warship = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealth = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split();
            while (command[0] != "Retire")
            {
                switch (command[0])
                {
                    case "Fire":
                        int index = int.Parse(command[1]);
                        int damage = int.Parse(command[2]);
                        if (IsValidIndexForPirates(index, pirates))
                        {
                            warship[index] -= damage;
                            if (warship[index] <= 0)
                            {
                                Console.WriteLine("You won! The enemy ship has sunken.");
                                return;
                            }
                        }
                        break;

                    case "Defend":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        damage = int.Parse(command[3]);
                        if (IsValidIndexForPirates(startIndex, pirates) && IsValidIndexForPirates(endIndex, pirates))
                        {
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                pirates[i] -= damage;
                                if (pirates[i] <= 0)
                                {
                                    Console.WriteLine("You lost! The pirate ship has sunken.");
                                    return;
                                }
                            }
                        }
                        break;

                    case "Repair":
                        index = int.Parse(command[1]);
                        int health = int.Parse(command[2]);
                        if (IsValidIndexForPirates(index, pirates))
                        {
                            pirates[index] += health;
                            if (pirates[index] > maxHealth)
                            {
                                pirates[index] = maxHealth;
                            }
                        }
                        break;

                    case "Status":
                        int counter = 0;
                        foreach (int section in pirates)
                        {
                            if (section < maxHealth * 0.2)
                            {
                                counter++;
                            }
                        }
                        Console.WriteLine($"{counter} sections need repair.");
                        break;
                }
                command = Console.ReadLine().Split();
            }

            int pirateShipSum = 0;
            int warshipSum = 0;
            foreach (int item in pirates)
            {
                pirateShipSum += item;
            }
            foreach (int item in warship)
            {
                warshipSum += item;
            }
            Console.WriteLine($"Pirate ship status: {pirateShipSum}");
            Console.WriteLine($"Warship status: {warshipSum}");
        }

        static bool IsValidIndexForPirates(int index, List<int> pirates)
        {
            if (index >= 0 && index < pirates.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
