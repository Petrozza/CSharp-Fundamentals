using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;

namespace Nikulden_s_meals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var guests = new Dictionary<string, List<string>>();
            int count = 0;
            while (input != "Stop")
            {
                string[] command = input.Split("-");
                switch (command[0])
                {
                    case "Like":
                        string guest = command[1];
                        string meal = command[2];
                        if (!guests.ContainsKey(guest))
                        {
                            guests.Add(guest, new List<string>());
                        }

                        if (!guests[guest].Contains(meal))
                        {
                            guests[guest].Add(meal);
                        }
                        break;

                    case "Unlike":
                        guest = command[1];
                        meal = command[2];
                        if (!guests.ContainsKey(guest))
                        {
                            Console.WriteLine($"{guest} is not at the party.");
                        }
                        else if (!guests[guest].Contains(meal))
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                        else
                        {
                            guests[guest].Remove(meal);
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                            count++;
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            
            foreach (var pair in guests.OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{pair.Key}: {string.Join(", ", pair.Value)}");
            }
            Console.WriteLine($"Unliked meals: {count}");
        }
    }
}
