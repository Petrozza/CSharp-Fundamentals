using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace froggy.squad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cardList = Console.ReadLine().Split(":").ToList();
            List<string> deck = new List<string>();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "Ready")
            {
                if (command[0] == "Add")
                {
                    string cardName = command[1];
                    if (cardList.Contains(cardName))
                    {
                        deck.Add(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }

                if (command[0] == "Insert")
                {
                    string cardName = command[1];
                    int index = int.Parse(command[2]);
                    if (cardList.Contains(cardName) && index >= 0 && index < deck.Count)
                    {
                        deck.Insert(index, cardName);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }

                if (command[0] == "Remove")
                {
                    string cardName = command[1];
                    if (deck.Contains(cardName))
                    {
                        deck.Remove(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                if (command[0] == "Swap")
                {
                    string cardName1 = command[1];
                    string cardName2 = command[2];
                    int c1 = deck.IndexOf(cardName1);
                    int c2 = deck.IndexOf(cardName2);

                    if (c1 < c2)
                    {
                        deck.Insert(c2, cardName1);
                        deck.Insert(c1, cardName2);
                        deck.RemoveAt(c1 + 1);
                        deck.RemoveAt(c2 + 1);
                    }
                    else if (c1 > c2)
                    {
                        deck.Insert(c1, cardName2);
                        deck.Insert(c2, cardName1);
                        deck.RemoveAt(c2 + 1);
                        deck.RemoveAt(c1 + 1);
                    }
                }
                if (command[0] == "Shuffle")
                {
                    deck.Reverse();
                }
                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", deck));

        }
    }
}
