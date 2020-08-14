using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = new Dictionary<string, List<string>>();
            var playTimes = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "start of concert")
            {
                string[] command = input.Split("; ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "Add")
                {
                    string bandName = command[1];
                    List<string> members = command[2].Split(", ").ToList();

                    if (!group.ContainsKey(bandName))
                    {
                        group.Add(bandName, members);
                        playTimes.Add(bandName, 0);
                    }
                    foreach (var member in members)
                    {
                        if (!group[bandName].Contains(member))
                        {
                            group[bandName].Add(member); 
                        }
                    }
                }
                if (command[0] == "Play")
                {
                    string bandName = command[1];
                    int time = int.Parse(command[2]);
                    
                    if (!group.ContainsKey(bandName))
                    {
                        group.Add(bandName, new List<string>());
                        playTimes.Add(bandName, time);
                    }
                    else
                    {
                        playTimes[bandName] += time; 
                    }
                }
            }
            string specialBand =  Console.ReadLine();

            Console.WriteLine($"Total time: {playTimes.Values.Sum()}");
            foreach (var kvp in playTimes.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            Console.WriteLine(specialBand);
            foreach (var member in group)
            {
                if (member.Key == specialBand)
                {
                    foreach (var item in member.Value)
                    {
                        Console.WriteLine($"=> {item}");

                    }
                }
            }
        }
    }
}
