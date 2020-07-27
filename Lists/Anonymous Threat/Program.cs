using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (startIndex > input.Count - 1)
                    {
                        startIndex = input.Count - 1;
                    }
                    if (endIndex >= input.Count)
                    {
                        endIndex = input.Count - 1;
                    }

                    string mergedElements = string.Empty;

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        mergedElements += input[i];
                    }

                    input.RemoveRange(startIndex, endIndex - startIndex + 1);
                    input.Insert(startIndex, mergedElements);

                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);

                    int partitions = int.Parse(command[2]);

                    string divided = input[index];
                    input.RemoveAt(index);
                    int step = divided.Length / partitions;

                    List<string> cutted = new List<string>();

                    for (int i = 0; i < partitions; i++)
                    {
                        if (i == partitions - 1)
                        {
                            cutted.Add(divided.Substring(i * step));
                        }
                        else
                        {
                            cutted.Add(divided.Substring(i * step, step));
                        }
                    }
                    input.InsertRange(index, cutted);

                }

                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
