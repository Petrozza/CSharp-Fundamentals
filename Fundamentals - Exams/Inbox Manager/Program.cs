using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            var emails = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Statistics")
                {
                    break;
                }
                string[] command = input.Split("->");

                switch (command[0])
                {
                    case "Add":
                        string userName = command[1];
                        if (emails.ContainsKey(userName))
                        {
                            Console.WriteLine($"{userName} is already registered");
                        }
                        else
                        {
                            emails.Add(userName, new List<string>());
                        }
                        break;

                    case "Send":
                        userName = command[1];
                        string mail = command[2];
                        if (emails.ContainsKey(userName))
                        {
                            emails[userName].Add(mail);
                        }
                        break;

                    case "Delete":
                        userName = command[1];
                        if (emails.ContainsKey(userName))
                        {
                            emails.Remove(userName);
                        }
                        else
                        {
                            Console.WriteLine($"{userName} not found!");
                        }
                        break;
                }
            }

            Console.WriteLine($"Users count: {emails.Count}");
            foreach (var kvp in emails.OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"- {item}");
                }
            }
        }
    }
}

