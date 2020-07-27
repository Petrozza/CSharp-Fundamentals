using System;
using System.Linq;

namespace Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxLenght = 0;
            int lastIndex = -1;

            int[] len = new int[nums.Length];
            int[] prev = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int k = 0; k < i; k++)
                {
                    if (nums[k] < nums[i] && len[k] + 1 > len[i])
                    {
                        len[i] = len[k] + 1;
                        prev[i] = k;
                    }
                }

                if (len[i] > maxLenght)
                {
                    maxLenght = len[i];
                    lastIndex = i;
                }
            }

            int[] LIS = new int[maxLenght];
            int currentIndex = maxLenght - 1;

            while (lastIndex != -1)
            {
                LIS[currentIndex] = nums[lastIndex];
                currentIndex--;
                lastIndex = prev[lastIndex];
            }

            Console.WriteLine(string.Join(" ", LIS));
        }
    }
}
