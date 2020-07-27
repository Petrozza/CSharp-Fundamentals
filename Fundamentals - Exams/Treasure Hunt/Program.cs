using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> loots = Console.ReadLine().Split("|").ToList();
            int initialCount = loots.Count;
            string[] command = Console.ReadLine().Split();

            while (command[0] != "Yohoho!")
            {
                switch (command[0])
                {
                    case "Loot":
                        string[] items = new string[command.Length - 1];
                        for (int i = 0; i < items.Length; i++)
                        {
                            items[i] = command[i + 1];
                            if (!loots.Contains(items[i]))
                            {
                                loots.Insert(0, items[i]);
                            }
                        }
                        break;

                    case "Drop":
                        int index = int.Parse(command[1]);
                        if (index >= 0 && index < loots.Count - 1)
                        {
                            string element = loots.ElementAt(index);
                            loots.Add(element);
                            loots.Remove(element);
                        }
                        break;

                    case "Steal":
                        int stolenCount = int.Parse(command[1]);
                        List<string> stolen = new List<string>();
                        if (loots.Count <= stolenCount)
                        {
                            for (int i = 0; i < loots.Count; i++)
                            {
                                stolen.Add(loots[i]);
                            }
                            loots.RemoveRange(0, loots.Count);
                            Console.WriteLine(string.Join(", ", stolen));
                        }
                        else
                        {
                            for (int i = 0; i < stolenCount; i++)
                            {
                                stolen.Add(loots[loots.Count - 1]);
                                loots.RemoveAt(loots.Count - 1);
                            }
                            stolen.Reverse();
                            Console.WriteLine(string.Join(", ", stolen));
                        }
                        break;
                }
                command = Console.ReadLine().Split();
            }
            if (loots.Count > 0)
            {
                double sumLenght = 0;
                foreach (string item in loots)
                {
                    sumLenght += item.Length;
                }
                double averageGain = sumLenght / loots.Count;
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }

        }
    }
}
