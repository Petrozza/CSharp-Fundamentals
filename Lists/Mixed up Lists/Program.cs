using System;
using System.Collections.Generic;
using System.Linq;

namespace Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList(); 
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();
            int startNumber = 0;
            int endNumber = 0;
            for (int i = 0; i < Math.Min(first.Count, second.Count); i++)
            {
                result.Add(first[i]);
                result.Add(second[second.Count - i - 1]);
            }

            if (first.Count > second.Count)
            {
                startNumber = first[first.Count-1];
                endNumber = first[first.Count - 2];
            }
            if (second.Count > first.Count)
            {
                startNumber = second[0];
                endNumber = second[1];
            }
            List<int> finalList = new List<int>();
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] > Math.Min(startNumber, endNumber) && result[i] < Math.Max(startNumber, endNumber))
                {
                    finalList.Add(result[i]);
                }
            }
            finalList.Sort();
            Console.Write(string.Join(" ", finalList));
        }

    }
}
