using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var cities = new Dictionary<string, List<int>>();

            while (input != "Sail")
            {
                string[] init = input.Split("||");
                string city = init[0];
                int population = int.Parse(init[1]);
                int gold = int.Parse(init[2]);

                if (!cities.ContainsKey(city))
                {
                    cities.Add(city, new List<int>());
                    cities[city].Add(population);
                    cities[city].Add(gold);
                }
                else
                {
                    cities[city][0] += population;
                    cities[city][1] += gold;
                }

                input = Console.ReadLine();
            }
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                string[] command = line.Split("=>");

                if (command.Contains("Plunder"))
                {
                    string town = command[1];
                    int people = int.Parse(command[2]);
                    int gold = int.Parse(command[3]);

                    cities[town][0] -= people;
                    cities[town][1] -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (cities[town][0] <= 0 || cities[town][1] <= 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        cities.Remove(town);
                    }
                }

                if (command.Contains("Prosper"))
                {
                    string town = command[1];
                    int gold = int.Parse(command[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    else
                    {
                        Console.Write($"{gold} gold added to the city treasury. ");
                        cities[town][1] += gold;
                        Console.WriteLine($"{town} now has {cities[town][1]} gold.");
                    }
                }
            }
            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var kvp in cities.OrderByDescending(x => x.Value[1]).ThenBy(y => y.Key))
                {
                    Console.WriteLine($"{kvp.Key} -> Population: {kvp.Value[0]} citizens, Gold: {kvp.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
