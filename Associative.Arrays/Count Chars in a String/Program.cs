using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            var count = new Dictionary<char, int>();

            foreach (char chr in str.Where(x => x!=' '))
            {
                if (count.ContainsKey(chr))
                {
                    count[chr]++;
                }
                else
                {
                    count.Add(chr, 1);
                }
            }

            foreach (var chr in count)
            {
                Console.WriteLine($"{chr.Key} -> {chr.Value}");
            }
        }
    }
}
