using System;
using System.Collections.Generic;
using System.Linq;

namespace Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var heros = new Dictionary<string, int[]>();

            for (int i = 0; i < n; i++)
            {
                string[] heroInput = Console.ReadLine().Split();
                string hero = heroInput[0];
                int HP = int.Parse(heroInput[1]);
                int MP = int.Parse(heroInput[2]);

                if (!heros.ContainsKey(hero))
                {
                    heros.Add(hero, new int[2]);
                }

                heros[hero][0] = HP;
                heros[hero][1] = MP;
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" - ");
                if (command[0] == "End")
                {
                    break;
                }

                switch (command[0])
                {
                    case "CastSpell":
                        string hero = command[1];
                        int MPNeeded = int.Parse(command[2]);
                        string spellName = command[3];

                        if (heros[hero][1] >= MPNeeded)
                        {
                            heros[hero][1] -= MPNeeded;
                            Console.WriteLine($"{hero} has successfully cast {spellName} and now has {heros[hero][1]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{hero} does not have enough MP to cast {spellName}!");
                        }
                        break;

                    case "TakeDamage":
                        hero = command[1];
                        int damage = int.Parse(command[2]);
                        string attacker = command[3];
                        heros[hero][0] -= damage;
                        if (heros[hero][0] > 0)
                        {
                            Console.WriteLine($"{hero} was hit for {damage} HP by {attacker} and now has {heros[hero][0]} HP left!");
                        }
                        else
                        {
                            Console.WriteLine($"{hero} has been killed by {attacker}!");
                            heros.Remove(hero);
                        }
                        break;

                    case "Recharge":
                        hero = command[1];
                        int amount = int.Parse(command[2]);
                        if (heros[hero][1] + amount > 200)
                        {
                            Console.WriteLine($"{hero} recharged for {200 - heros[hero][1]} MP!");
                            heros[hero][1] = 200;
                        }
                        else
                        {
                            heros[hero][1] += amount;
                            Console.WriteLine($"{hero} recharged for {amount} MP!");
                        }
                        break;

                    case "Heal":
                        hero = command[1];
                        amount = int.Parse(command[2]);
                        if (heros[hero][0] + amount > 100)
                        {
                            Console.WriteLine($"{hero} healed for {100 - heros[hero][0]} HP!");
                            heros[hero][0] = 100;
                        }
                        else
                        {
                            heros[hero][0] += amount;
                            Console.WriteLine($"{hero} healed for {amount} HP!");
                        }
                        break;
                }
            }
            foreach (var kvp in heros.OrderByDescending(hp => hp.Value[0]).ThenBy(n => n.Key))
            { 
                Console.WriteLine(kvp.Key);
                Console.WriteLine($"  HP: {kvp.Value[0]}");
                Console.WriteLine($"  MP: {kvp.Value[1]}");
            }
        }
    }
}
