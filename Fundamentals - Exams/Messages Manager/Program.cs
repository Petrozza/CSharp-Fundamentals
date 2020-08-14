using System;
using System.Collections.Generic;
using System.Linq;

namespace Messages_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            var messages = new Dictionary<string, List<int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Statistics")
                {
                    break;
                }
                string[] command = input.Split('=');

                if (command[0] == "Add")
                {
                    string userName = command[1];
                    int sent = int.Parse(command[2]);
                    int received = int.Parse(command[3]);

                    if (!messages.ContainsKey(userName))
                    {
                        messages.Add(userName, new List<int>());
                        messages[userName].Add(sent);
                        messages[userName].Add(received);
                    }
                }
                
                else if (command[0] == "Message")
                {
                    string sender = command[1];
                    string receiver = command[2];
                    if (messages.ContainsKey(sender) && messages.ContainsKey(receiver))
                    {
                        messages[sender][0] += 1;
                        messages[receiver][1] += 1;
                        if (messages[sender][0] + messages[sender][1] == capacity)
                        {
                            Console.WriteLine($"{sender} reached the capacity!");
                            messages.Remove(sender);
                        }
                        if (messages[receiver][0] + messages[receiver][1] == capacity)
                        {
                            Console.WriteLine($"{receiver} reached the capacity!");
                            messages.Remove(receiver);
                        }
                    }
                }

                else if (command[0] == "Empty")
                {
                    string userName = command[1];
                    messages.Remove(userName);
                    if (userName == "All")
                    {
                        messages.Clear();
                    }
                }
            }
            Console.WriteLine($"Users count: {messages.Count}");
            foreach (var item in messages.OrderByDescending(c => c.Value[1]).ThenBy(b => b.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value[0] + item.Value[1]}");
            }
        }
    }
}
