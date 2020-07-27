using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var attackPlanets = new Dictionary<string, char>();
            int attacked = 0;
            int destroyed = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = "[sStTaArR]";
                var code = Regex.Matches(input, pattern).Count;

                string decrypted = string.Empty;

                foreach (var symbol in input )
                {
                    decrypted += (char)(symbol - code);
                }

                string pattern2 = @"([^@\-!:>]*(?<planet>[A-Z][a-z]+)\w?:[^@\-!:>]*?(?<population>\d+)![^@\-!:>]*(?<attack>[A|D])!->(?<count>\d+))";

                Match message = Regex.Match(decrypted, pattern2);

                if (!message.Success)
                {
                    continue;
                }
                string planet = message.Groups["planet"].Value;
                int population = int.Parse(message.Groups["population"].Value);
                char attack = char.Parse(message.Groups["attack"].Value);

                if (attack == 'A')
                {
                    attacked++;
                }
                else
                {
                    destroyed++;
                }
                
                int count = int.Parse(message.Groups["count"].Value);

                if (attackPlanets.ContainsKey(planet))
                {
                    attackPlanets.Add(planet, attack);
                }
                attackPlanets[planet] = attack;

            }

            Console.WriteLine($"Attacked planets: {attacked}");

            foreach (var item in attackPlanets.Where(x => x.Value == 'A').OrderBy(y => y.Key))
            {
                Console.WriteLine($"-> {item.Key}");
            }

            Console.WriteLine($"Destroyed planets: {destroyed}");

            foreach (var item in attackPlanets.Where(x => x.Value == 'D').OrderBy(y => y.Key))
            {
                Console.WriteLine($"-> {item.Key}");
            }
        }
    }
}
