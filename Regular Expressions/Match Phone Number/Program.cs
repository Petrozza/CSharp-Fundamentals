﻿using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^| )[+359]+( |-)2\2\d{3}\2\d{4}\b";
            string phones = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phones, pattern);

            string[] matchedPhones = phoneMatches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
