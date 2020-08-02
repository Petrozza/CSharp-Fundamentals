using System;
using System.Text.RegularExpressions;

namespace Boss_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string bossPattern = @"(\|)(?<name>[A-Z]{3,})\1";
                string bossTitle = @":#(?<title>[A-Za-z]+ ?[A-Za-z]+)#";

                Match bossName = Regex.Match(input, bossPattern);
                Match title = Regex.Match(input, bossTitle);
                if (bossName.Success && title.Success)
                {
                    string name = bossName.Groups["name"].Value;
                    string bTitle = title.Groups["title"].Value;
                    Console.WriteLine($"{name}, The {bTitle}");
                    Console.WriteLine($">> Strength: {name.Length}");
                    Console.WriteLine($">> Armour: {bTitle.Length}");
                }
                else
                {
                    Console.WriteLine($"Access denied!");
                }
            }
        }
    }
}
