using System;
using System.Text.RegularExpressions;

namespace Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long coolDigits = 1L;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    coolDigits *= long.Parse(input[i].ToString());
                }
            }

            Console.WriteLine($"Cool threshold: {coolDigits}");

            string pattern = @"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})(\1)";

            MatchCollection emojis = Regex.Matches(input, pattern);
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");

            foreach (Match emoji in emojis)
            {
                int sumAscii = 0;

                string emos = emoji.Groups["emoji"].Value.ToString();

                for (int j = 0; j < emos.Length; j++)
                {
                    sumAscii += emos[j];
                }

                if (sumAscii >= coolDigits)
                {
                    Console.WriteLine(emoji.Value);
                }
            }
        }
    }
}
