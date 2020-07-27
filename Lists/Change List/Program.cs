using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split().ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Delete":
                        DeleteElement(nums, command);
                        break;

                    case "Insert":
                        InsertElementAtPosition(nums, command);
                        break;

                }

                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", nums));

            static void DeleteElement(List<string> numbers, string[] input)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == input[1])
                    {
                        numbers.RemoveAt(i);
                    }

                }
            }

            static void InsertElementAtPosition(List<string> numbers, string[] input)
            {
                string element = input[1];
                int position = int.Parse(input[2]);
                numbers.Insert(position, element);
            }
        }
    }
}
