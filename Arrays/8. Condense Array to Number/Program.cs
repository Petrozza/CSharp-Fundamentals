using System;
using System.Linq;

namespace _8._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int result = 0;
            if (arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
            }
            else
            {
                while (arr.Length > 1)
                {
                    int[] splitted = new int[arr.Length - 1];

                    for (int i = 0; i < splitted.Length; i++)
                    {
                        splitted[i] = arr[i] + arr[i + 1];
                        result = splitted[i];
                    }

                    arr = splitted;
                }
                Console.WriteLine(result);

            }
        }
    }
}
