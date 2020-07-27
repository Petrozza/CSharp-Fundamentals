using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Season end")
                {
                    break;
                }

                string[] line = input.Split(new string[] { " -> ", " vs " }, StringSplitOptions.None).ToArray();

                if (input.Contains(" -> "))
                {
                    string player = line[0];
                    string position = line[1];
                    int skill = int.Parse(line[2]);

                    if (players.ContainsKey(player))
                    {
                        if (players[player].ContainsKey(position))
                        {
                            if (players[player][position] < skill)
                            {
                                players[player][position] = skill;
                            }
                        }
                        
                        else
                        {
                            players[player][position] = skill;
                        }

                    }
                    else
                    {
                        var fighters = new Dictionary<string, int>();
                        fighters.Add(position, skill);
                        players[player] = fighters;

                    }
                }



                else if (input.Contains(" vs "))
                {
                    string fighter1 = line[0];
                    string fighter2 = line[1];

                    if (players.ContainsKey(fighter1) && players.ContainsKey(fighter2))
                    {
                        string playerToRemove = "";
                        foreach (var pos1 in players[fighter1])
                        {
                            foreach (var pos2 in players[fighter2])
                            {
                                if (pos1.Key == pos2.Key)
                                {
                                    if (players[fighter1].Values.Sum() > players[fighter2].Values.Sum())
                                    {
                                        playerToRemove = fighter2;
                                    }
                                    else if (players[fighter1].Values.Sum() < players[fighter2].Values.Sum())
                                    {
                                        playerToRemove = fighter1;
                                    }
                                }
                            }
                        }
                        players.Remove(playerToRemove);
                    }
                }
            }
            foreach (var kvp in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Values.Sum()} skill");
                foreach (var player in kvp.Value.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
                {
                    Console.WriteLine($"- {player.Key} <::> {player.Value}");
                }
            }
        }
    }
}
