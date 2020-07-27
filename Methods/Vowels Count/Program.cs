using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            PrintVowelsFromWord(word);
        }

        static void PrintVowelsFromWord(string word)
        {
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || 
                    word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);

        }
    }
}
