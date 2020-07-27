using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {


            var urgent = new Dictionary<string, int>();
            var junk = new SortedDictionary<string, int>();
            urgent["shards"] = 0;
            urgent["fragments"] = 0;
            urgent["motes"] = 0;
            bool isNoOver250 = true;

            while (isNoOver250)
            {
                string[] input = Console.ReadLine().ToLower().Split(' ').ToArray();
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];

                    if (urgent.ContainsKey(material))
                    {
                        urgent[material] += quantity;

                        if (urgent[material] >= 250)
                        {
                            urgent[material] -= 250;
                            string result = string.Empty;
                            switch (material)
                            {
                                case "shards":
                                    result = "Shadowmourne"; break;
                                case "fragments":
                                    result = "Valanyr"; break;
                                case "motes":
                                    result = "Dragonwrath"; break;
                            }
                            Console.WriteLine($"{result} obtained!");
                            isNoOver250 = false;
                            break;
                        }
                    }

                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, 0);
                        }
                        junk[material] += quantity;
                    }
                }
            }

            var orderedUrgentDiction = urgent.OrderByDescending(u => u.Value).ThenBy(s => s.Key);

            foreach (var item in orderedUrgentDiction)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}

