using System;
using System.Text.RegularExpressions;

namespace Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, @"@#+(?<barcode>[A-Z]+[a-zA-Z0-9]{4,}[A-Z]+)@#+");
                
                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                string barcode = match.Groups["barcode"].Value;
                string group = string.Empty;
                
                for (int j = 0; j < barcode.Length; j++)
                {
                    if (char.IsDigit(barcode[j]))
                    {
                        group += barcode[j];
                    }
                }
                
                if (group == string.Empty)             
                {
                    Console.WriteLine($"Product group: 00");
                }
                else
                {
                    Console.WriteLine($"Product group: {group}");
                }
            }
        }
    }
}
