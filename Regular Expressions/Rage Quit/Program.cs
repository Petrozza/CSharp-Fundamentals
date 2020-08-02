using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string shit = Console.ReadLine();

            string pattern = @"([\D]+[\d]+)";

            MatchCollection matches = Regex.Matches(shit, pattern);

            List<string> pieces = new List<string>();
            foreach (Match item in matches)
            {
                pieces.Add(item.Value);
            }
            StringBuilder result = new StringBuilder();
            foreach (var part in pieces)
            {
                Match matchNumber = Regex.Match(part.ToString(), @"\d+");
                Match matchString = Regex.Match(part.ToString(), @"^[^\d]+");

                int number = int.Parse(matchNumber.Value);
                string strink = matchString.Value.ToUpper();

               result.Append(string.Concat(Enumerable.Repeat(strink, number)));
            }
           string count = string.Empty;
            for (int i = 0; i < result.Length; i++)
            {
                 
                if (!count.Contains(result[i]))
                {
                    count += result[i];
                }
            }
            Console.WriteLine($"Unique symbols used: {count.Length}");
            Console.WriteLine(result);
        }
    }
}
