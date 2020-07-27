using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            SortedDictionary<int, int> sortedD = new SortedDictionary<int, int>();

            foreach (var number in numbers)
            {
                if (sortedD.ContainsKey(number))
                {
                    sortedD[number]++;
                }
                else
                {
                    sortedD[number] = 1;
                }
            }
            foreach (var number  in sortedD)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");

            }
        }
    }
}
