using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Message_Encrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"([*@])(?<request>[A-Z][a-z]{2,})(\1):\s(\[(?<letter1>[a-zA-Z])\]\|)(\[(?<letter2>[a-zA-Z])\]\|)(\[(?<letter3>[a-zA-Z])\]\|)$";

                Match match = Regex.Match(input, pattern);
                if (!match.Success)
                {
                    Console.WriteLine("Valid message not found!");
                    continue;
                }

                string request = match.Groups["request"].Value;
                char ch1 = char.Parse(match.Groups["letter1"].Value);
                char ch2 = char.Parse(match.Groups["letter2"].Value);
                char ch3 = char.Parse(match.Groups["letter3"].Value);
                int asc1 = ch1;
                int asc2 = ch2;
                int asc3 = ch3;
                List<int> numbs = new List<int>();
                numbs.Add(asc1);
                numbs.Add(asc2);
                numbs.Add(asc3);
                Console.WriteLine($"{request}: {string.Join(" ", numbs)}");
            }
        }
    }
}
