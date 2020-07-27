using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Xml.Serialization;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "exchange")
                {
                    if (int.Parse(command[1]) < 0 || int.Parse(command[1]) > arr.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    arr = GetSplittedArea(arr, command);

                }

                else if (command[0] == "max")
                {
                    if (GetIndexOfMaxEvenOddIndex(arr, command) == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                    int result = GetIndexOfMaxEvenOddIndex(arr, command);
                    Console.WriteLine(result);
                }

                else if (command[0] == "min")
                {
                    if (GetIndexOfMinEvenOddIndex(arr, command) == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                    int result = GetIndexOfMinEvenOddIndex(arr, command);
                    Console.WriteLine(result);
                }

                else if (command[0] == "first")
                {
                    if (int.Parse(command[1]) > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    GetFirstEvenOddElements(arr, command);
                }

                else if (command[0] == "last")
                {
                    if (int.Parse(command[1]) > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    GetLastEvenOddElements(arr, command);
                }

            }

            Console.Write('[');
            Console.Write(string.Join(", ", arr).ToArray());
            Console.WriteLine(']');
        }

        static int[] GetSplittedArea(int[] arr, string[] command)
        {
            int index = int.Parse(command[1]);
            int[] exLeft = new int[index + 1];
            int[] exRight = new int[arr.Length - index - 1];
            for (int i = 0; i < exLeft.Length; i++)
            {
                exLeft[i] = arr[i];
            }
            for (int j = 0; j < exRight.Length; j++)
            {
                exRight[j] = arr[index + j + 1];
            }

            int[] exchange = exRight.Concat(exLeft).ToArray();

            return exchange;
        }

        static int GetIndexOfMaxEvenOddIndex(int[] arr, string[] command)
        {
            int maxElement = int.MinValue;
            int maxIndex = -1;
            if (command[1] == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        if (arr[i] >= maxElement)
                        {
                            maxElement = arr[i];
                            maxIndex = i;
                        }
                    }
                }

            }

            if (command[1] == "odd")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        if (arr[i] >= maxElement)
                        {
                            maxElement = arr[i];
                            maxIndex = i;
                        }
                    }
                }

            }
            return maxIndex;
        }

        static int GetIndexOfMinEvenOddIndex(int[] arr, string[] command)
        {
            int minElement = int.MaxValue;
            int minIndex = -1;
            if (command[1] == "even")
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        if (arr[i] <= minElement)
                        {
                            minElement = arr[i];
                            minIndex = i;
                        }
                    }
                }
            }

            else if (command[1] == "odd")
            {

                for (int i = 0; i < arr.Length; i++)
                {

                    if (arr[i] % 2 != 0)
                    {
                        if (arr[i] <= minElement)
                        {
                            minElement = arr[i];
                            minIndex = i;
                        }
                    }
                }

            }
            return minIndex;
        }

        static void GetFirstEvenOddElements(int[] arr, string[] command)
        {
            int count = int.Parse(command[1]);
            string first = string.Empty;

            if (command[2] == "even")
            {
                int counter = 0;

                for (int i = 0; i < arr.Length; i++)
                {

                    if (arr[i] % 2 == 0)
                    {
                        first += arr[i] + " ";
                        counter++;
                    }
                    if (counter == count)
                    {
                        break; // count = arr.Length;
                    }
                }
                var result = first.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine("[" + String.Join(", ", result) + "]");
                }
            }

            else if (command[2] == "odd")
            {
                int counter = 0;

                for (int i = 0; i < arr.Length; i++)
                {

                    if (arr[i] % 2 != 0)
                    {
                        first += arr[i] + " ";
                        counter++;
                    }
                    if (counter == count)
                    {
                        break; // count = arr.Length;
                    }
                }
                var result = first.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine("[" + String.Join(", ", result) + "]");
                }
            }
        }

        static void GetLastEvenOddElements(int[] arr, string[] command)
        {
            int count = int.Parse(command[1]);
            string last = string.Empty;

            if (command[2] == "even")
            {

                int counter = 0;

                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 == 0)
                    {
                        last += arr[i] + " ";
                        counter++;

                        if (counter == count)
                        {
                            break;
                        }
                    }
                }
                var result = last.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();
                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine("[" + String.Join(", ", result) + "]");
                }
            }

            if (command[2] == "odd")
            {
                int counter = 0;

                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 != 0)
                    {
                        last += arr[i] + " ";
                        counter++;
                        if (counter == count)
                        {
                            break;
                        }
                    }
                }
                var result = last.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();
                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine("[" + String.Join(", ", result) + "]");
                }
            }

        }
    }
}

