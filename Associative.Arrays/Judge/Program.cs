using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.InteropServices;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, int>>();
            var sumPoints = new Dictionary<string, int>();
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "no more time")
                {
                    break;
                }

                string[] command = input.Split(" -> ").ToArray();

                string user = command[0];
                string contest = command[1];
                int points = int.Parse(command[2]);
                

                if (!data.ContainsKey(contest))
                {
                    data[contest] =  new Dictionary<string, int>();
                    data[contest][user] = points;
                }

                else
                {
                    if (!data[contest].ContainsKey(user))
                    {
                        data[contest][user] = points;
                    }

                    else
                    {
                        if (data[contest][user] < points)
                        {
                            data[contest][user] = points;
                        }
                    }
                }
            }

            foreach (var kvp in data)
            {
                Dictionary<string, int> nested2 = kvp.Value;
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} participants");
                int counter = 1;

                foreach (var name in kvp.Value.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
                {
                    Console.WriteLine($"{counter}. {name.Key} <::> {name.Value}");
                    counter++;
                }
                counter = 1; 
            }

            Console.WriteLine("Individual standings:");

            foreach (var mem in data)
            {
                foreach (var kvp in mem.Value)
                {
                    if (!sumPoints.ContainsKey(kvp.Key))
                    {
                        sumPoints.Add(kvp.Key, kvp.Value);
                    }
                    else
                    {
                        sumPoints[kvp.Key] = sumPoints[kvp.Key] + kvp.Value;
                    }
                }
            }

            int counter1 = 0;
            foreach (var name in sumPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                counter1++;
                Console.WriteLine($"{counter1}. {name.Key} -> {name.Value}");
            }
        }
    }
}
