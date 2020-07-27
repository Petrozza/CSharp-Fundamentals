using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            for (int j = 1; j <= rotations; j++)
            {
                int temp = 0;
                int[] newArr = new int[arr.Length];

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    temp = arr[0];
                    newArr[i] = arr[i + 1];
                }
                newArr[newArr.Length - 1] = temp;
                arr = newArr;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
