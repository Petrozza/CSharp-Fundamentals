using System;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var word in input)
            {
                bool isValid = false;
                if (word.Length > 3 && word.Length < 16)
                {
                    isValid = true;
                }
                else
                {
                    continue;
                }

                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsDigit(word[i]) || char.IsLetter(word[i])
                        || word[i] == '-' || word[i] == '_')
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
