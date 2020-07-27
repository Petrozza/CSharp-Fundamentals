using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            PrintMiddleSymbols(word);


        }

        static void PrintMiddleSymbols(string word)
        {
            if (word.Length % 2 == 0)
            {
                int index1 = (word.Length / 2) - 1;
                int index2 = (word.Length / 2);
                Console.WriteLine($"{word[index1]}{word[index2]}");
            }

            else
            {
                int index = word.Length / 2;
                Console.WriteLine(word[index]);
            }

        }
    }
}
