using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nether.Realms
{
    class Program
    {
        static void Main(string[] args)

        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var demons = new SortedDictionary<string, List<double>>();

            string healthPattern = @"[^+.\-*/\d\s]";
            string damagePattern = @"[-]?\d+\.?\d*";
            string damageOpPattern = @"[*\/]";

            for (int i = 0; i < input.Length; i++)
            {
                if (!demons.ContainsKey(input[i]))
                {
                    demons.Add(input[i], new List<double>());

                }

                MatchCollection healthSymbols = Regex.Matches(input[i], healthPattern);
                MatchCollection damageSymbols = Regex.Matches(input[i], damagePattern);
                MatchCollection damageOpSymbols = Regex.Matches(input[i], damageOpPattern);

                string healthString = String.Concat(healthSymbols);

                double health = 0.0;
                foreach (Match item in healthSymbols)
                {
                    health += char.Parse(item.Value);
                }

                double damage = 0.0;
                foreach (Match item in damageSymbols)
                {
                    string digit = item.Value;
                    damage += double.Parse(digit);
                }

                foreach (Match item in damageOpSymbols)
                {
                    string dmgops = item.Value;
                    if (dmgops == "*")
                    {
                        damage *= 2;
                    }
                    else if (dmgops == "/")
                    {
                        damage /= 2;
                    }

                }

                demons[input[i]].Add(health);
                demons[input[i]].Add(damage);
            }

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");

            }

        }
    }
}

