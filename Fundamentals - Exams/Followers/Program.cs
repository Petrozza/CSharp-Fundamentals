using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Followers
{
    class Program
    {

        static void Main(string[] args)
        {
            var folowers = new Dictionary<string, List<int>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Log out")
                {
                    break;
                }

                string[] command = input.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "New follower":
                        string userName = command[1];
                        if (!folowers.ContainsKey(userName))
                        {
                            folowers.Add(userName, new List<int> { 0, 0 });
                        }
                        break;
                    case "Like":
                        userName = command[1];
                        int count = int.Parse(command[2]);
                        if (!folowers.ContainsKey(userName))
                        {
                            folowers.Add(userName, new List<int> { 0, 0 });
                            folowers[userName][0] = count;
                        }
                        else
                        {
                            folowers[userName][0] += count;
                        }
                        break;

                    case "Comment":
                        userName = command[1];
                        if (!folowers.ContainsKey(userName))
                        {
                            folowers.Add(userName, new List<int> { 0, 0 });
                            folowers[userName][1] = 1;
                        }
                        else
                        {
                            folowers[userName][1] += 1;
                        }
                        break;

                    case "Blocked":
                        userName = command[1];
                        if (!folowers.ContainsKey(userName))
                        {
                            Console.WriteLine($"{userName} doesn't exist.");
                        }
                        else
                        {
                            folowers.Remove(userName);
                        }
                        break;

                }
            }
            Console.WriteLine($"{folowers.Count} followers");
            foreach (var kvp in folowers.OrderByDescending(x => x.Value[0]).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value[0] + kvp.Value[1]}");
            }
        }

    }

}