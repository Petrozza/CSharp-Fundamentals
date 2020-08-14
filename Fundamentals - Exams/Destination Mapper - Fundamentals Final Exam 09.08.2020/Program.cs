using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string places = Console.ReadLine();
            string patternCity = @"([=/])(?<city>[A-Z][A-Za-z]{2,})(\1)";

            MatchCollection matches = Regex.Matches(places, patternCity);

            List<string> locations = new List<string>();
            int sumLength = 0;
            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    locations.Add(match.Groups["city"].Value);
                    sumLength += match.Groups["city"].Value.Length;
                }
            }
            Console.WriteLine($"Destinations: {string.Join(", ", locations)}");
            Console.WriteLine($"Travel Points: {sumLength}");
        }
    }
}