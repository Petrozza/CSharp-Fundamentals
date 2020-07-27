using System;
using System.Linq;

namespace _7._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool isIdent = true;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != arr1[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isIdent = false;
                    break;
                }
                else
                {
                    sum += arr[i];
                    isIdent = true;
                }
            }
            if (isIdent)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
