using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collection = Console.ReadLine().Split(", ").ToList();
            string[] command = Console.ReadLine().Split(" - ");

            while (command[0] != "Craft!")
            {
                if (command[0] == "Collect")
                {
                    if (!ItemExistsInList(command[1], collection))
                    {
                        collection.Add(command[1]);
                    }
                }

                if (command[0] == "Drop")
                {
                    if (ItemExistsInList(command[1], collection))
                    {
                        collection.Remove(command[1]);
                    }
                }

                if (command[0] == "Combine Items")
                {
                    List<string> combo = command[1].Split(":").ToList();
                    if (ItemExistsInList(combo[0], collection))
                    {
                        int index = collection.IndexOf(combo[0]);
                        collection.Insert(index + 1, combo[1]);
                    }
                }

                if (command[0] == "Renew")
                {
                    if (ItemExistsInList(command[1], collection))
                    {
                        collection.Remove(command[1]);
                        collection.Add(command[1]);
                    }
                }
                command = Console.ReadLine().Split(" - ");
            }

            Console.WriteLine(string.Join(", ", collection));
        }

        static bool ItemExistsInList(string material, List<string> items)
        {
            if (items.Contains(material))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
