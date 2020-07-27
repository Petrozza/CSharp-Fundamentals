using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Sum_Adjacent_Equal_Numbers

{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> arr = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < arr.Count - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    arr[i] += arr[i + 1];
                    arr.RemoveAt(i + 1);
                    i = -1;
                }

            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}