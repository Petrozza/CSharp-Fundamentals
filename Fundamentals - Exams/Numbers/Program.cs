using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = numbers.Sum();
            double average = sum * 1.0 / numbers.Length;
            //Console.WriteLine(average);

            List<int> averageTops = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > average)
                {
                    averageTops.Add(numbers[i]);
                }
                else
                {
                    continue;
                }
            }
            averageTops.Sort();
            averageTops.Reverse();

            if (averageTops.Count > 5)
            {
                averageTops.RemoveRange(5, averageTops.Count - 5);
            }
            if (averageTops.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", averageTops));
            }
        }
    }
}

