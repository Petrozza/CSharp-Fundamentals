using System;
using System.Collections.Generic;
using System.Linq;

namespace On_the_Way_to_Annapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            var stores = new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] command = input.Split("->");
                string store = command[1];
                if (command[0] == "Add")
                {
                    string[] items = command[2].Split(',').ToArray();
                    if (!stores.ContainsKey(store))
                    {
                        stores.Add(store,new List<string>());
                        foreach (var item in items)
                        {
                            stores[store].Add(item);
                        }                      
                    }
                    else
                    {
                        foreach (var item in items)
                        {
                            stores[store].Add(item);
                        }
                    }
                }

                if (command[0] == "Remove")
                {
                    if (stores.ContainsKey(store))
                    {
                        stores.Remove(store);
                    }
                }

            }

            Console.WriteLine("Stores list:");
            foreach (var kvp in stores.OrderByDescending(x => x.Value.Count).ThenByDescending(y => y.Key))
            {
                Console.WriteLine(kvp.Key);
                List<string> items = kvp.Value;

                foreach (var item in items)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
