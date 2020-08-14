using System;
using System.Text.RegularExpressions;

namespace Arriving_in_Kathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Last note")
                {
                    break;
                }
                string pattern = @"^(?<peak>[a-zA-Z0-9@$?!#]+)=(?<length>\d+)<<(?<code>.*)$";

                Match match = Regex.Match(input, pattern);
                
                if (!match.Success)
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }
                
                string rawPeak = match.Groups["peak"].Value;
                string peak = string.Empty;
               
                for (int i = 0; i < rawPeak.Length; i++)
                {
                    if (char.IsLetterOrDigit(rawPeak[i]))
                    {
                        peak += rawPeak[i];
                    }
                } 
                
                string len = match.Groups["length"].Value;
                int length = int.Parse(len);
                string code = match.Groups["code"].Value;
                
                if (code.Length == length)
                {
                    Console.WriteLine($"Coordinates found! {peak} -> {code}");
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}
