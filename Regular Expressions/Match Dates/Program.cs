using System;
using System.Text.RegularExpressions;

namespace Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?<day>\d{2})([\/\.-])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            var text = Console.ReadLine();

            //Regex regex = new Regex(pattern);

            var result = Regex.Matches(text, pattern);

            foreach (Match date in result)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
