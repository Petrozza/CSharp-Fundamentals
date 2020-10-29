using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var plantRarity = new Dictionary<string, int>();
            var plantRaiting = new Dictionary<string, List<int>>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split("<->");
                string plant = info[0];
                int rarity = int.Parse(info[1]);
                if (plantRarity.ContainsKey(plant))
                {
                    plantRarity[plant] = rarity;
                }
                else
                {
                    plantRarity.Add(plant, rarity);
                    plantRaiting.Add(plant, new List<int>());
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Exhibition")
                {
                    break;
                }
                string[] command = input.Split(new string[] { ": ", " - " }, StringSplitOptions.RemoveEmptyEntries);

                if (command[0].Contains("Rate"))
                {
                    string plant = command[1];
                    int rate = int.Parse(command[2]);
                    if (plantRaiting.ContainsKey(plant))
                    {
                        plantRaiting[plant].Add(rate);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                else if (command[0].Contains("Update"))
                {
                    string plant = command[1];
                    int newRarity = int.Parse(command[2]);
                    if (plantRarity.ContainsKey(plant))
                    {
                        plantRarity[plant] = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                else if (command[0].Contains("Reset"))
                {
                    string plant = command[1];
                    if (plantRaiting.ContainsKey(plant))
                    {
                        plantRaiting[plant].Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                else
                {
                    Console.WriteLine("error");
                }
            }

            Console.WriteLine("Plants for the exhibition:");

            var avg = new Dictionary<string, List<double>>();
            foreach (var item in plantRaiting)
            {
                if (item.Value.Count == 0)
                {
                    avg.Add(item.Key, new List<double> { 0 });
                }
                else
                {
                    avg.Add(item.Key, new List<double> { item.Value.Average() });
                }
            }

            foreach (var pair in plantRarity)
            {
                avg[pair.Key].Add(pair.Value);
            }

            foreach (var kvp in avg.OrderByDescending(x => x.Value[1]).ThenBy(y => y.Value[0]))
            {
                Console.WriteLine($"- { kvp.Key}; Rarity: {kvp.Value[1]}; Rating: {kvp.Value[0]:f2}");
            }

        }
    }
}

