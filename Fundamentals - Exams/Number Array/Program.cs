using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Switch":
                        int index = int.Parse(command[1]);
                        if (IsValidIndex(index, arr))
                        {
                            arr[index] = arr[index] - (arr[index] * 2);
                        }
                        break;

                    case "Change":
                        index = int.Parse(command[1]);
                        if (IsValidIndex(index, arr))
                        {
                            arr[index] = int.Parse(command[2]);
                        }
                        break;

                    case "Sum":
                        int sum = 0;
                        foreach (int item in arr)
                        {
                            if (command[1] == "Negative" && item < 0)
                            {
                                sum += item;
                            }
                            else if (command[1] == "Positive" && item >= 0)
                            {
                                sum += item;
                            }
                            else if (command[1] == "All")
                            {
                                sum += item;
                            }
                        }
                        Console.WriteLine(sum);
                        break;
                }
                command = Console.ReadLine().Split();
            }
            foreach (int item in arr)
            {
                if (item >= 0)
                {
                    Console.Write($"{item} ");
                }
            }
        }

        static bool IsValidIndex(int index, int[] arr)
        {
            if (index >= 0 && index < arr.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}