using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                if (command[0] == "Add")
                {
                    nums.Add(int.Parse(command[1]));
                }

                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);
                    int number = int.Parse(command[1]);
                    if (index < 0 || index >= nums.Count)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine().Split();
                        continue;
                    }
                    else
                    {
                        nums.Insert(index, number);
                    }
                }

                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);
                    if (index < 0 || index >= nums.Count)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine().Split();
                        continue;
                    }
                    else
                    {
                        nums.RemoveAt(index);
                    }
                }

                else if (command[1] == "left")
                {
                    int count = int.Parse(command[2]);
                    for (int i = 1; i <= count; i++)
                    {
                        nums.Add(nums[0]);
                        nums.RemoveAt(0);
                    }
                }

                else if (command[1] == "right")
                {
                    int counter = int.Parse(command[2]);
                    for (int i = 1; i <= counter; i++)
                    {
                        nums.Insert(0, nums[nums.Count - 1]);
                        nums.RemoveAt(nums.Count - 1);
                    }
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
