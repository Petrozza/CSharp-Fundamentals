using System;
using System.Text.RegularExpressions;

namespace The_Isle_of_Man_TT_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                string pattern = @"([#$%\*&])(?<name>[A-Za-z]+)\1=(?<length>\d+)!!(?<code>.+)$";

                Match match = Regex.Match(input, pattern);
                if (!match.Success)
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }
                string nameRacer = match.Groups["name"].Value;
                int lengthOfCode = int.Parse(match.Groups["length"].Value);
                string code = match.Groups["code"].Value;

                string decryptedCode = string.Empty;
                if (code.Length == lengthOfCode)
                {
                    for (int i = 0; i < code.Length; i++)
                    {
                        decryptedCode += (char)(code[i] + lengthOfCode);
                    }
                    Console.WriteLine($"Coordinates found! {nameRacer} -> {decryptedCode}");
                    return;
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}
