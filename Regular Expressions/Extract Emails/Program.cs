using System;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=\s)(?<user>[a-zA-Z]+[._-]?[a-zAz]+)@([a-z]+[.-])[a-z*.([a-z]{2,}\b";

            var email = Regex.Matches(input, pattern);
            Console.WriteLine(string.Join(Environment.NewLine, email));
        }
    }
}
