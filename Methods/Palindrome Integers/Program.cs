using System;
using System.Threading.Channels;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            IsPalindrome(word);
        }

        static void IsPalindrome(string word)
        {
            bool palindrome = true;

            while (word != "END")
            {
                string newWord = string.Empty;
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    newWord += Convert.ToChar(word[i]);
                }

                for (int j = 0; j < newWord.Length; j++)
                {
                    palindrome = true;
                    if (word[j] != newWord[j])
                    {
                        palindrome = false;
                        break;
                    }
                }
                Console.WriteLine(palindrome.ToString().ToLower());
                word = Console.ReadLine();
            }
        }
    }
}
 