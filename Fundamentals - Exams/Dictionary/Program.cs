using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
         {
            string[] wordsAndDefifnitions = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            var dictio = new SortedDictionary<string, List<string>>();
            foreach (var item in wordsAndDefifnitions)
            {
                string[] temp = item.Split(": ");
                string word = temp[0];
                string definition = temp[1];
                if (!dictio.ContainsKey(word))
                {
                    dictio.Add(word, new List<string>());
                    dictio[word].Add(definition);
                }
                else
                {
                    dictio[word].Add(definition);
                }
            }

            string[] onlyWords = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var wort in onlyWords)
            {
                if (dictio.ContainsKey(wort))
                {
                    Console.WriteLine($"{wort}");
                }
                else
                {
                    continue;
                }
                List<string> defs = dictio[wort];
                foreach (var item in defs.OrderByDescending(x => x.Length))
                {
                    Console.WriteLine($" -{item}");
                }
            }
            
            string command = Console.ReadLine();
            if (command == "List")
            {
                foreach (var kvp in dictio)
                {
                    Console.Write($"{kvp.Key} ");
                }
            }
            else if (command == "End")
            {
                return;
            }
        }
    }
}
