using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Battle_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string, List<int>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Results")
                {
                    break;
                }

                string[] command = input.Split(':');

                switch (command[0])
                {
                    case "Add":
                        string personName = command[1];
                        int health = int.Parse(command[2]);
                        int energy = int.Parse(command[3]);

                        if (!people.ContainsKey(personName))
                        {
                            people.Add(personName, new List<int>());
                            people[personName].Add(health);
                            people[personName].Add(energy);
                        }
                        else
                        {
                            people[personName][0] += health;
                        }
                        break;

                    case "Attack":
                        string attackerName = command[1];
                        string defenderName = command[2];
                        int damage = int.Parse(command[3]);

                        if (people.ContainsKey(attackerName) && people.ContainsKey(defenderName))
                        {
                            people[defenderName][0] -= damage;
                            if (people[defenderName][0] <= 0)
                            {
                                Console.WriteLine($"{defenderName} was disqualified!");
                                people.Remove(defenderName);
                            }
                            people[attackerName][1] -= 1;
                            if (people[attackerName][1] == 0)
                            {
                                Console.WriteLine($"{attackerName} was disqualified!");
                                people.Remove(attackerName);
                            }
                        }
                        break;

                    case "Delete":
                        string userName = command[1];
                        if (people.ContainsKey(userName))
                        {
                            people.Remove(userName);
                        }
                        
                        if (userName == "All")
                        { 
                            people.Clear();
                        }
                        break;
                }
            }
            Console.WriteLine($"People count: {people.Count}");
            foreach (var person in people.OrderByDescending(x => x.Value[0]).ThenBy( y => y.Key))
            {
                Console.WriteLine($"{person.Key} - {person.Value[0]} - {person.Value[1]}");
            }
        }
    }
}
