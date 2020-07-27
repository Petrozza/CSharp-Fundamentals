using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            Regex regex = new Regex(input);

            MatchCollection result = Regex.Matches(input, pattern);

            foreach (Match nameeee in result)
            {
                Console.Write(nameeee.Value +" ");
            }
            Console.WriteLine();
        }
    }
}
