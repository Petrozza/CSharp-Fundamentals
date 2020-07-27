using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "Stop")
            {

                if (command[0] == "Delete")
                {
                    int index = int.Parse(command[1]) + 1;

                    if (index >= 0 && index < words.Count)
                    {
                        words.RemoveAt(index);
                    }
                }

                else if (command[0] == "Swap")
                {
                    string word1 = command[1];
                    string word2 = command[2];

                    if (words.Contains(word1) && words.Contains(word2))
                    {
                        int index1 = words.IndexOf(word1);
                        int index2 = words.IndexOf(word2);
                        words[index2] = word1;
                        words[index1] = word2;
                    }
                }

                else if (command[0] == "Put")
                {
                    string word = command[1];
                    int index = int.Parse(command[2]) - 1;

                    if (index <= words.Count && index >= 0)
                    {
                        words.Insert(index, word);
                    }
                }

                else if (command[0] == "Sort")
                {
                    words.Sort();
                    words.Reverse();
                }

                else if (command[0] == "Replace")
                {
                    string word1 = command[1];
                    string word2 = command[2];

                    if (words.Contains(word2))
                    {
                        int index = words.IndexOf(word2);
                        words.Remove(word2);
                        words.Insert(index, word1);
                    }
                }

                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
