using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string[] substrings = Console.ReadLine().Split().ToArray();
            string pattern = @"^[d-z{}\|#]+$";
            Match match = Regex.Match(line1, pattern);
            if (!match.Success)
            {
                Console.WriteLine("This is not the book you are looking for.");
                return;
            }

            string sub1 = substrings[0];
            string sub2 = substrings[1];

            string decoded = string.Empty;
            for (int i = 0; i < line1.Length; i++)
            {
                decoded += (char)(line1[i]- 3);
            }
            decoded = decoded.Replace(sub1, sub2);
            Console.WriteLine(decoded);
        }
    }
}
