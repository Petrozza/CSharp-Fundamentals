using System;
using System.Linq;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            StringRandomizer randomizer = new StringRandomizer();

            randomizer.Words = Console.ReadLine().Split().ToArray();
            randomizer.Rndomize();
            randomizer.PrintWords();
        }
    }
    public class StringRandomizer
    {
        public string[] Words { get; set; }

        public void Rndomize()
        {
            Random rnd = new Random();
            for (int i = 0; i < Words.Length; i++)
            {
                int randomPosition = rnd.Next(0, Words.Length);
                string temp = Words[i];
                Words[i] = Words[randomPosition];
                Words[randomPosition] = temp;
            }
        }

        public void PrintWords()
        {
            Console.WriteLine(string.Join(Environment.NewLine, Words));
        }

    }
    
}
