using System;
using System.Collections.Generic;
using System.Linq;

namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> nums2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();
            for (int i = 0; i < Math.Min(nums1.Count, nums2.Count); i++)
            {
                result.Add(nums1[i]);
                result.Add(nums2[i]);
            }

            if (nums1.Count > nums2.Count)
            {
                for (int j = nums2.Count; j < nums1.Count; j++)
                {
                    result.Add(nums1[j]);
                }
            }
            else if (nums1.Count < nums2.Count)
                for (int j = nums1.Count; j < nums2.Count; j++)
                {
                    result.Add(nums2[j]);
                }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
