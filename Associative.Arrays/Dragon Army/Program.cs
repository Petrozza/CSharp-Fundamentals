using System;
using System.Collections.Generic;
using System.Linq;

namespace Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var types = new Dictionary<string, SortedDictionary<string, int[]>>();

            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split();

                string type = input[0];
                string name = input[1];
                int damage = 0;
                int health = 0;
                int armor = 0;

                damage = input[2] == "null" ? 45 : int.Parse(input[2]);
                health = input[3] == "null" ? 250 : int.Parse(input[3]);
                armor = input[4] == "null" ? 10 : int.Parse(input[4]);


                if (!types.ContainsKey(type))
                {
                    types.Add(type, new SortedDictionary<string, int[]>());
                }

                if (!types[type].ContainsKey(name))
                {
                    types[type][name] = new int[3];
                }

                types[type][name][0] = damage;
                types[type][name][1] = health;
                types[type][name][2] = armor;

            }

            foreach (var kvp in types)
            {
                Console.WriteLine($"{kvp.Key}::({kvp.Value.Select(x => x.Value[0]).Average():f2}/{kvp.Value.Select(x => x.Value[1]).Average():f2}/{kvp.Value.Select(x => x.Value[2]).Average():f2})");

                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"-{item.Key} -> damage: {item.Value[0]}, health: {item.Value[1]}, armor: {item.Value[2]}");
                }
            }
        }
    }
}
