using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombnumber = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = bombnumber[0];
            int power = bombnumber[1];

            CalculateBomdBlastRange(nums, bomb, power);

            int sum = 0;
            foreach (int item in nums)
            {
                sum += item;
            } 
            Console.WriteLine(sum);
        }

        static void CalculateBomdBlastRange(List<int> nums, int bomb, int power)
        {
            for (int i = 0; i < nums.Count - 1; i++)
            {
                


                if (nums[i] == bomb)
                {
                    int beginBombIndex = i - power;
                    int endBombIndex = i + power;

                    if (beginBombIndex < 0)
                    {
                        beginBombIndex = 0;
                    }
                    if (endBombIndex > nums.Count-1)
                    {
                        endBombIndex = nums.Count-1;
                    }
                    for (int j = beginBombIndex; j <= endBombIndex; j++)
                    {
                        nums.RemoveAt(beginBombIndex);
                    }
                    i--;
                }
            }
        }
    }
}
