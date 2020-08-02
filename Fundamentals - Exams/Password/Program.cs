using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"(.+)>(?<encryption>[\d]{3}\|[a-z]{3}\|[A-Z]{3}\|[^<>]{3})<(\1)";
                Match result = Regex.Match(input, pattern);
                if (result.Success)
                {
                    string password = result.Groups["encryption"].Value;
                    password = password.Replace("|", "");
                    Console.WriteLine($"Password: {password}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }

            }
        }
    }
}
