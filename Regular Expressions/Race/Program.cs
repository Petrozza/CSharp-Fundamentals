using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");
            var racers = new Dictionary<string, int>();
            for (int i = 0; i < names.Length; i++)
            {
                if (!racers.ContainsKey(names[i]))
                {
                    racers.Add(names[i], 0);
                }
            }

            while (true)
            {
                string code = Console.ReadLine();
                if (code == "end of race")
                {
                    break;
                }

                string patternLetters = @"[a-zA-Z]";
                string patternDigits = @"(\d)";
                Regex regexLetters = new Regex(patternLetters);
                Regex regexDigits = new Regex(patternDigits);

                MatchCollection matchLetters = Regex.Matches(code, patternLetters);
                MatchCollection matchDigits = Regex.Matches(code, patternDigits);

                string name = "";
                foreach (var ch in matchLetters)
                {
                    name += ch;
                }
                string digits = "";

                foreach (var ch in matchDigits)
                {
                    digits += ch;
                }
                int sumDigits = 0;

                for (int i = 0; i < digits.Length; i++)
                {
                    int digit = int.Parse(digits[i].ToString());
                    while (digit > 0)
                    {
                        sumDigits += digit % 10;
                        digit /= 10;
                    }
                }

                if (racers.ContainsKey(name))
                {
                    racers[name] += sumDigits;
                }
            }

            int counter = 1;
            foreach (var kvp in racers.OrderByDescending(x => x.Value))
            {
                if (counter == 1)
                {
                    Console.WriteLine($"{counter}st place: {kvp.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"{counter}nd place: {kvp.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"{counter}rd place: {kvp.Key}");
                }
                counter++;

                if (counter > 3)
                {
                    break;
                }
            }
        }
    }
}



