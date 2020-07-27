using System;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] arr1 = new int[numbers.Length / 2];
            int[] arr2 = new int[numbers.Length / 2];

            int[] arr1L = new int[numbers.Length / 4];
            int[] arr1R = new int[numbers.Length / 4];
            for (int i = 0; i < numbers.Length / 4; i++)
            {
                arr1L[i] = numbers[i];
                arr1R[i] = numbers[numbers.Length - 1 - i];
            }
            Array.Reverse(arr1L);

            for (int j = 0; j < numbers.Length / 2; j++)
            {
                arr2[j] = numbers[numbers.Length / 4 + j];
            }

            arr1L.CopyTo(arr1, 0);
            arr1R.CopyTo(arr1, arr1L.Length);

            int[] sumar = new int[arr1.Length];
            string result = "";
            for (int k = 0; k < arr1.Length; k++)
            {
                sumar[k] = arr1[k] + arr2[k];
                result += sumar[k] + " ";
            }
            Console.WriteLine(result);
        }
    }
}
