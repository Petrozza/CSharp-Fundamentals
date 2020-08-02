using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split("|");

            string part1 = line[0]; //firs capital letter
            string part2 = line[1]; //length of word
            string part3 = line[2]; //

            string pattern1 = @"([#$%*&])(?<capitals>[A-Z]+)(\1)";
            Match match1 = Regex.Match(part1, pattern1);
            string capitalLetters = match1.Groups["capitals"].Value; //CAPITAL LETTERS
            List<char> capLett = new List<char>();
            for (int i = 0; i < capitalLetters.Length; i++)
            {
                string pattern2 = @"\d\d:\d\d";
                MatchCollection matches2 = Regex.Matches(part2, pattern2);
                foreach (Match item in matches2)
                {
                    string[] pieces = item.Value.Split(':');            // ASCII, length
                    char ascii = (char)int.Parse(pieces[0].ToUpper());
                    int length = int.Parse(pieces[1]) + 1;

                    if (ascii == capitalLetters[i])
                    {
                        if (capLett.Contains(ascii))
                        {
                            continue;
                        }
                        else
                        {
                            capLett.Add(ascii);
                        }

                        string pattern3 = @"\b[A-Z][a-z]+[^\s]*\b";
                        MatchCollection matches3 = Regex.Matches(part3, pattern3);
                        foreach (Match items3 in matches3)              //Words
                        {
                            string word = items3.Value;
                            if (word[0] == ascii && word.Length == length)
                            {
                                Console.WriteLine(word);
                            }

                        }

                    }

                }

            }
        }
    }
}
