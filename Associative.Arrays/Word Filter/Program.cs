using System;
using System.Linq;

namespace Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            string[] oddLenghtWords = words.Where(w => w.Length % 2 == 0).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine, oddLenghtWords));
        }
    }
}
