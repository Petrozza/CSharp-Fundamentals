using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"!(?<command>[A-Z][a-z]{2,})!:(?<message>\[(?<messageneto>[a-zA-Z]{8,})\])";

                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string command = match.Groups["command"].Value;
                    string message = match.Groups["message"].Value;
                    string nakedMessage = match.Groups["messageneto"].Value;

                    StringBuilder result = new StringBuilder();
                    for (int j= 0; j < nakedMessage.Length; j++)
                    {
                        result.Append((int)nakedMessage[j] + " ");
                    }
                    Console.WriteLine($"{command}: {result}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
            
        }
    }
}
