using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;

namespace Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "end")
            {
                StringBuilder message = new StringBuilder();

                for (int i = 0; i < input.Length; i++)
                {
                    message.Append((char)(input[i] - key)); 

                }
                string pattern = @"@(?<name>[A-Za-z]+)[^@\-!:>]*!(?<behavior>[NG])!";
                ;
                Match match = Regex.Match(message.ToString(), pattern);
                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }
                string name = match.Groups["name"].Value;
                char behavior = char.Parse(match.Groups["behavior"].Value);
                if (behavior == 'G')
                {
                    Console.WriteLine(name);
                }

                input = Console.ReadLine();
            }
        }
    }
}
