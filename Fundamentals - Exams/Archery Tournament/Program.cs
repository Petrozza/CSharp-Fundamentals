using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split("|").Select(int.Parse).ToList();
            char[] separator = { ' ', '@' };
            string[] command = Console.ReadLine().Split(separator);
            int ourPoints = 0;

            while (command[0] != "Game")
            {
                int targetIndex = 0;

                if (command[0] == "Reverse")
                {
                    targets.Reverse();
                    command = Console.ReadLine().Split(separator);
                    continue;
                }

                else if (command[0] == "Game")
                {
                    command = Console.ReadLine().Split(separator);
                    continue;
                }

                else if (command[1] == "Left")
                {
                    int startIndex = int.Parse(command[2]);
                    if (startIndex < 0 || startIndex > targets.Count - 1)
                    {
                        command = Console.ReadLine().Split(separator);
                        continue;
                    }
                    int Lenght = int.Parse(command[3]);
                    targetIndex = startIndex - Lenght;

                    while (targetIndex < 0)
                    {
                        targetIndex += targets.Count;
                    }
                }

                else if (command[1] == "Right")
                {
                    int startIndex = int.Parse(command[2]);
                    if (startIndex < 0 || startIndex > targets.Count - 1)
                    {
                        command = Console.ReadLine().Split(separator);
                        continue;
                    }
                    int Lenght = int.Parse(command[3]);
                    targetIndex = startIndex + Lenght;

                    while (targetIndex > targets.Count)
                    {
                        targetIndex -= targets.Count;
                    }
                }

                if (targets[targetIndex] < 5)
                {
                    ourPoints += targets[targetIndex];
                    targets[targetIndex] = 0;
                }

                else
                {
                    targets[targetIndex] -= 5;
                    ourPoints += 5;
                }
                command = Console.ReadLine().Split(separator);
            }
            Console.WriteLine(string.Join(" - ", targets));
            Console.WriteLine($"Iskren finished the archery tournament with {ourPoints} points!");
        }
    }
}
