using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_Sessions
{
    class Program
    {
        static void Main(string[] args)
        {
            var race = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] command = input.Split("->");

                if (command[0] == "Add")
                {
                    string road = command[1];
                    string racer = command[2];

                    if (!race.ContainsKey(road))
                    {
                        race.Add(road, new List<string>());
                        //race[road].Add(racer);
                    }
                    race[road].Add(racer);
                }

                else if (command[0] == "Move")
                {
                    string currentRoad = command[1];
                    string racer = command[2];
                    string nextRoad = command[3];
                    if (race[currentRoad].Contains(racer))
                    {
                        race[nextRoad].Add(racer);
                        race[currentRoad].Remove(racer);
                    }
                }

                else if (command[0] == "Close")
                {
                    string road = command[1];
                    if (race.ContainsKey(road))
                    {
                        race.Remove(road);
                    }
                }
            }
            Console.WriteLine("Practice sessions:");
            foreach (var item in race.OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key))
            {
                Console.WriteLine(item.Key);

                List<string> racers = item.Value;
                foreach (var racer in racers)
                {
                    Console.WriteLine($"++{racer}");
                }
            }
        }
    }
}
