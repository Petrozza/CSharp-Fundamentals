using System;
using System.Text.RegularExpressions;

namespace Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                string ticket = input[i];
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue; 
                }
                string left = ticket.Substring(0, 10);
                string right = ticket.Substring(10, 10);
                string pattern = @"\@{6,10}|\#{6,10}|\${6,10}|\^{6,10}";

                Match matchLeft1 = Regex.Match(left, pattern);
                Match matchRight1 = Regex.Match(right, pattern);

                if (!matchLeft1.Success || !matchRight1.Success)
                {
                    Console.WriteLine($"ticket \"{ ticket}\" - no match"); 
                    continue;
                }

                string symbolsL = matchLeft1.Value;
                string symbolsR = matchRight1.Value;
                string symbols = "";
                if (symbolsL.Length > symbolsR.Length)
                {
                    symbols = symbolsR;
                }
                else
                {
                    symbols = symbolsL;
                }
                char matchSymbol = symbols[1];

                if (symbols.Length >=6 && symbols.Length <= 9)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {symbols.Length}{matchSymbol}");
                }
                else if (symbols.Length == 10)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {symbols.Length}{matchSymbol} Jackpot!");
                }

            }
        }
    }
}
