using System;
using System.Linq;

namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
         {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                int sumRight = 0;
                for (int k = i + 1; k < array.Length; k++)
                {
                    sumRight += array[k];
                }

                int sumLeft = 0;
                for (int j = i - 1; j >=0; j--)
                {
                    sumLeft += array[j];
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    isFound = true;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
