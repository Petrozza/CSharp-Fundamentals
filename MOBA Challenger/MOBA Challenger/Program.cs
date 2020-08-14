using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var tier = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Season end")
                {
                    break;
                }
                string[] command = input.Split(new string[] { " -> ", " vs " }, StringSplitOptions.None).ToArray();

                if (input.Contains(" -> "))
                {
                    string player = command[0];
                    string position = command[1];
                    int skill = int.Parse(command[2]);

                    if (!tier.ContainsKey(player))
                    {
                        tier.Add(player, new Dictionary<string, int>());
                        if (!tier[player].ContainsKey(position))
                        {
                            tier[player].Add(position, skill);
                        }
                        else
                        {
                            if (tier[player][position] < skill)
                            {
                                tier[player][position] = skill;
                            }
                        }
                    }
                    else
                    {
                        if (!tier[player].ContainsKey(position))
                        {
                            tier[player].Add(position, skill);
                        }
                    }

                    if (tier[player][position] < skill)
                    {
                        tier[player][position] = skill;
                    }
                }
                else if (input.Contains(" vs "))
                {
                    string fighter1 = command[0];
                    string fighter2 = command[1];

                    if (tier.ContainsKey(fighter1) && tier.ContainsKey(fighter2))
                    {
                        string playerToDelete = string.Empty;
                        foreach (var item1 in tier[fighter1])
                        {
                            foreach (var item2 in tier[fighter2])
                            {
                                if (item1.Key == item2.Key)
                                {
                                    if (tier[fighter1].Values.Sum() > tier[fighter2].Values.Sum())
                                    {
                                        playerToDelete = fighter2;
                                    }
                                    else if (tier[fighter1].Values.Sum() < tier[fighter2].Values.Sum())
                                    {
                                        playerToDelete = fighter1;
                                    }
                                }
                            }
                        }
                        tier.Remove(playerToDelete);

                    }
                }

            }
            foreach (var kvp in tier.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Values.Sum()} skill");

                var rating = kvp.Value;
                foreach (var item in rating.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
                {
                    Console.WriteLine($" - {item.Key} <::> {item.Value}");
                }
            }
        }
    }
}