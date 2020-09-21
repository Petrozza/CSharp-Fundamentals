using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([#\|])(?<name>[a-zA-Z\s]+)(\1)(?<date>\d{2}\/\d{2}\/\d{2}){1}(\1)(?<calories>\d{1,5})(\1)";
            
            MatchCollection matches = Regex.Matches(input, pattern);
            int sumCalories = 0;
            List<string> output = new List<string>();
            foreach (Match item in matches)
            {
                if (item.Success)
                {
                    string name = item.Groups["name"].Value;
                    string expDate = item.Groups["date"].Value;
                    int calories = int.Parse(item.Groups["calories"].Value);
                    if (calories >= 0 && calories <= 10000)
                    {
                        sumCalories += calories;
                        output.Add($"Item: {name}, Best before: {expDate}, Nutrition: {calories}");
                    }
                    else
                    {
                        break;
                    }
                    
                }
                
            }
            Console.WriteLine($"You have food to last you for: {sumCalories / 2000} days!");
            Console.WriteLine(string.Join(Environment.NewLine, output));


        }
    }
}
