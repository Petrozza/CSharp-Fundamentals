using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Add":
                        AddNumber(nums, command);
                        break;
                    case "Remove":
                        RemoveNumber(nums, command);
                        break;
                    case "RemoveAt":
                        RemoveAtIndex(nums, command);
                        break;
                    case "Insert":
                        InserNumberAtIndex(nums, command);
                        break;
                }

                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", nums));
        }

        static void AddNumber(List<int> nums, string[] command)
        {
            nums.Add(int.Parse(command[1]));
        }

        static void RemoveNumber(List<int> nums, string[] command)
        {
            nums.Remove(int.Parse(command[1]));
        }

        static void RemoveAtIndex(List<int> nums, string[] command)
        {
            nums.RemoveAt(int.Parse(command[1]));
        }

        static void InserNumberAtIndex(List<int> nums, string[] command)
        {
            nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
        }
    }
}
