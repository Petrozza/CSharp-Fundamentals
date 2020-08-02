using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            var heros = new Dictionary<string, List<string>>();

             while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                string[] input = line.Split();

                if (input[0] == "Enroll")
                {
                    string heroName = input[1];
                    if (!heros.ContainsKey(heroName))
                    {
                        heros.Add(heroName, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                }

                else if (input[0] == "Learn")
                {
                    string heroName = input[1];
                    string spellName = input[2];

                    if (!heros.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                        continue;
                    }
                    else
                    {
                        if (!heros[heroName].Contains(spellName))
                        {
                            heros[heroName].Add(spellName);

                        }
                        else
                        {
                            Console.WriteLine($"{heroName} has already learnt {spellName}.");
                        }
                    }

                }

                else if (input[0] == "Unlearn")
                {
                    string heroName = input[1];
                    string spellName = input[2];

                    if (!heros.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                        continue;
                    }
                    else
                    {
                        if (heros[heroName].Contains(spellName))
                        {
                            heros[heroName].Remove(spellName);
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't know {spellName}.");
                        }
                    }
                }
            }
            Console.WriteLine("Heroes:");
            foreach (var item in heros.OrderByDescending(x => x.Value.Count()).ThenBy(y => y.Key))
            {
                Console.WriteLine($"== {item.Key}: {string.Join(", ", item.Value)}");
            }
        }
    }
}
