using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = Console.ReadLine().Split(", ");
            string[] command = Console.ReadLine().Split();
            int blackListedCounter = 0;
            int lostNamesCounter = 0;
            while (command[0] != "Report")
            {
                switch (command[0])
                {
                    case "Blacklist":
                        bool isFound = false;
                        for (int j = 0; j < friends.Length; j++)
                        {

                            if (friends[j] == command[1])
                            {
                                Console.WriteLine($"{friends[j]} was blacklisted.");
                                friends[j] = "Blacklisted";
                                blackListedCounter++;
                                isFound = true;
                            }
                        }
                        if (!isFound)
                        {
                            Console.WriteLine($"{command[1]} was not found.");
                        }
                        break;

                    case "Error":
                        if (friends[int.Parse(command[1])] != "Blacklisted"
                            && friends[int.Parse(command[1])] != "Lost")
                        {
                            Console.WriteLine($"{friends[int.Parse(command[1])]} was lost due to an error.");
                            friends[int.Parse(command[1])] = "Lost";
                            lostNamesCounter++;
                        }
                        break;

                    case "Change":
                        if (int.Parse(command[1]) <= friends.Length - 1
                            && int.Parse(command[1]) >= 0)
                        {
                            Console.WriteLine($"{friends[int.Parse(command[1])]} changed his username to {command[2]}.");
                            friends[int.Parse(command[1])] = command[2];
                        }
                        break;
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine($"Blacklisted names: {blackListedCounter}");
            Console.WriteLine($"Lost names: {lostNamesCounter}");
            Console.WriteLine(string.Join(" ", friends));
        }
    }
}

