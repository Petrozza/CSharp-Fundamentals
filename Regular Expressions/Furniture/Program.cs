using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\w+)<<(\d.+)!(\d+)";
            string text = Console.ReadLine();
            List<string> output = new List<string>();

            double sum = 0;
            while (text != "Purchase")
            {

                Match result = Regex.Match(text, pattern);

                if (result.Success)
                {
                    string name = result.Groups[1].Value;
                    double price = double.Parse(result.Groups[2].Value);
                    int quantity = int.Parse(result.Groups[3].Value);

                    output.Add(name);
                    sum += price * quantity;
                }
                
                text = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            if (output.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, output));
            }
            Console.WriteLine($"Total money spend: {sum:f2}");

            

        }
    }
}
