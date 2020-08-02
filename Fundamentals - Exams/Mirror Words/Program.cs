using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MatchCollection words = Regex.Matches(input, @"([@#])(?<word1>[a-zA-Z]{3,})(\1)(\1)(?<word2>[a-zA-Z]{3,})(\1)");
            List<string> pairs = new List<string>();
            foreach (Match item in words)
            {
                string word1 = item.Groups["word1"].Value.ToString();
                string word2 = item.Groups["word2"].Value.ToString();
                string word2Back = "";

                for (int i = word2.Length - 1; i >= 0; i--)
                {
                    word2Back += word2[i];
                }

                if (word1 == word2Back)
                {
                    string pairWords = word1 + " <=> " + word2;
                    pairs.Add(pairWords);
                }

            }
            if (words.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else if (words.Count > 0)
            {
                Console.WriteLine($"{words.Count} word pairs found!");
            }

            if (pairs.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else if (pairs.Count > 0)
            {
                Console.WriteLine("The mirror words are:");

                Console.Write(string.Join(", ", pairs));
            }
        }
    }
}
