using System;
using System.Text.RegularExpressions;

namespace Message_Decrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"^([$%])(?<request>[A-Z][a-z]{2,})\1:\s\[(?<number1>\d*)\]\|\[(?<number2>\d*)\]\|\[(?<number3>\d*)\]\|$";
                Match match = Regex.Match(input, pattern);
                if (!match.Success)
                {
                    Console.WriteLine("Valid message not found!");
                    continue;
                }
                string req = match.Groups["request"].Value;
                string numer1 = match.Groups["number1"].Value;
                string numer2 = match.Groups["number2"].Value;
                string numer3 = match.Groups["number3"].Value;
                int num1 = int.Parse(numer1);
                int num2 = int.Parse(numer2);
                int num3 = int.Parse(numer3);

                Console.WriteLine($"{req}: {(char)num1}{(char)num2}{(char)num3}");
            }
        }
    }
}
