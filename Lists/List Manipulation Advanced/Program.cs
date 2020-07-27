using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();
            int count = 0;
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Contains":
                        CheckIfListContainNumber(nums, command);
                        break;
                    case "PrintEven":
                        PrintEven(nums);
                        break;
                    case "PrintOdd":
                        PrintOdd(nums);
                        break;
                    case "GetSum":
                        PrinSumOfElements(nums);
                        break;
                    case "Filter":
                        PrintUnderCondition(nums, command);
                        break;
                    case "Add":
                        nums.Add(int.Parse(command[1]));
                        count++;
                        break;
                    case "Remove":
                        nums.Remove(int.Parse(command[1]));
                        count++;
                        break;
                    case "RemoveAt":
                        nums.RemoveAt(int.Parse(command[1]));
                        count++;
                        break;
                    case "Insert":
                        int number = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        nums.Insert(index, number);
                        count++;
                        break;

                }


                command = Console.ReadLine().Split();
            }
            if (count > 0)
            {
                Console.WriteLine(string.Join(" ", nums));
            }

        }

        static void PrintUnderCondition(List<int> nums, string[] command)
        {
            string oper = command[1];
            int digit = int.Parse(command[2]);

            if (oper == "<")
            {
                foreach (int item in nums)
                {
                    if (item < digit)
                    {
                        Console.Write($"{item} ");
                    }
                }
                
            }
            else if (oper == ">")
            {
                foreach (int item in nums)
                {
                    if (item > digit)
                    {
                        Console.Write($"{item} ");
                    }
                }

            }
            else if (oper == "<=")
            {
                foreach (int item in nums)
                {
                    if (item <= digit)
                    {
                        Console.Write($"{item} ");
                    }
                }

            }
            else if (oper == ">=")
            {
                foreach (int item in nums)
                {
                    if (item >= digit)
                    {
                        Console.Write($"{item} ");
                    }
                }

            }
            Console.WriteLine();
        }

        static void PrinSumOfElements(List<int> nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }

        static void PrintOdd(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    Console.Write($"{nums[i]} ");
                }
            }
            Console.WriteLine();

        }

        static void PrintEven(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] %2 == 0)
                {
                    Console.Write($"{nums[i]} ");
                }
            }
            Console.WriteLine();

        }
        static void CheckIfListContainNumber(List<int> nums, string[] command)
        {
            if (nums.Contains(int.Parse(command[1])))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
    }
}
