﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < Math.Max(first.Count, second.Count); i++)
            {
                if (first[0] > second[0])
                {
                    first.Add(first[0]);
                    first.Add(second[0]);
                    first.RemoveAt(0);
                    second.RemoveAt(0);
                    if (first.Count == 0)
                    {
                        Console.WriteLine($"Second player wins! Sum: {second.Sum()}");
                        break;
                    }
                    if (second.Count == 0)
                    {
                        Console.WriteLine($"First player wins! Sum: {first.Sum()}");
                        break;
                    }
                    i--;
                    continue;
                }
                else if (first[0] < second[0])
                {
                    second.Add(second[0]);
                    second.Add(first[0]);
                    second.RemoveAt(0);
                    first.RemoveAt(0);
                    if (first.Count == 0)
                    {
                        Console.WriteLine($"Second player wins! Sum: {second.Sum()}");
                        break;
                    }
                    if (second.Count == 0)
                    {
                        Console.WriteLine($"First player wins! Sum: {first.Sum()}");
                        break;
                    }
                    i--;
                    continue;
                }
                else
                {
                    second.RemoveAt(0);
                    first.RemoveAt(0);
                    if (first.Count == 0)
                    {
                        Console.WriteLine($"Second player wins! Sum: {second.Sum()}");
                        break;
                    }
                    if (second.Count == 0)
                    {
                        Console.WriteLine($"First player wins! Sum: {first.Sum()}");
                        break;
                    }
                    i--;
                    continue;
                }
            }
           
        }

    }
}
